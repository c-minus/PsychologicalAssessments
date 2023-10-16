using System.Text.Json;
using Microsoft.AspNetCore.Components.Forms;
using PsychologicalAssessments.Orchestrator.Base;
using PsychologicalAssessments.Orchestrator.CategoryMap;
using PsychologicalAssessments.Orchestrator.DataOutput;
using PsychologicalAssessments.Orchestrator.DataSeed;
using PsychologicalAssessments.Orchestrator.Dependencies;
using PsychologicalAssessments.Orchestrator.Profile;
using PsychologicalAssessments.Orchestrator.Rules;
using PsychologicalAssessments.Orchestrator.ScoringType;
using PsychologicalAssessments.Orchestrator.StateFactory;
using PsychologicalAssessments.Orchestrator.Tresult;

namespace PsychologicalAssessments.Orchestrator.Service;

public class OrchestratorService : IOrchestratorService
{
    private readonly IDependenciesFactory _dependenciesFactory;
    private readonly IDataSeed _dataSeed;
    private readonly ITresultCalculator _tresultCalculator;
    private readonly IDataOutput _dataOutput;
    private IStateFactory? _stateFactory;
    private IScoringType? _scoringType;
    private ICategoryMapFactory? _categoryMapFactory;
    private IRuleFactory? _ruleFactory;
    private IProfileFactory? _profileFactory;
    private IDataTemplate? _dataTemplate;
    private Snapshot? _snapshot;
    private List<KeyValuePair<byte, string>>? _states = new();
    private int _stateCategoryIndex = 0;
    private int _stateProfileIndex = 0;

    public OrchestratorService
    (
        IDependenciesFactory dependenciesFactory,
        IDataSeed dataSeed,
        ITresultCalculator tresultCalculator,
        IDataOutput dataOutput
    )
    {
        _dependenciesFactory = dependenciesFactory;
        _dataSeed = dataSeed;
        _tresultCalculator = tresultCalculator;
        _dataOutput = dataOutput;
    }

    public async Task<Snapshot> Orchestrate(
        ServiceType serviceType,
        IBrowserFile file)
    {
        try
        {
            _snapshot = new();
            SetDependencies(serviceType);
            SetStates();

            var subject = await _dataSeed.GetAsync(file);
            CloneAndAddToSnapshot(subject, _states![0]);

            SetScoringType(subject.Questions!);
            CloneAndAddToSnapshot(subject, _states![1]);

            SetScore(subject.Questions!);
            CloneAndAddToSnapshot(subject, _states![2]);

            SetCategories(subject.Questions!);
            CloneAndAddToSnapshot(subject, _states![3]);

            ProcessRules(subject, subject.Questions!);

            subject.Profile = _profileFactory?.Create(subject.GenderInternal, subject.Age);
            CloneAndAddToSnapshot(subject, _states[_stateProfileIndex]);
            
            subject.TResult = _tresultCalculator.Calculate(subject);
            CloneAndAddToSnapshot(subject, _states[_stateProfileIndex + 1]);

            var template = _dataTemplate?.GetTemplate(subject);
            var output = await _dataOutput.GetByteArray(template!);

            _snapshot!.Output = output;

            return _snapshot;
        }
        catch (Exception e)
        {
            _snapshot!.Exception = e;
            return _snapshot;
        }
    }
    
    private void SetDependencies(ServiceType serviceType)
    {
        var dependencies = _dependenciesFactory?.Get(serviceType);

        _stateFactory = dependencies?.StateFactory! ?? throw new NullReferenceException("StateFactory is null");
        _scoringType = dependencies?.ScoringType! ?? throw new NullReferenceException("ScoringType is null");
        _categoryMapFactory = dependencies?.CategoryMapFactory! ??
                              throw new NullReferenceException("CategoryMapFactory is null");
        _ruleFactory = dependencies?.RuleFactory! ?? throw new NullReferenceException("RuleFactory is null");
        _profileFactory = dependencies?.ProfileFactory! ??
                          throw new NullReferenceException("ProfileFactory is null");
        _dataTemplate = dependencies?.DataTemplate! ?? throw new NullReferenceException("DataTemplate is null");
    }

    private void CloneAndAddToSnapshot(Subject subject, KeyValuePair<byte, string> state)
    {
        subject.CurrentState = state;
        var serialized = JsonSerializer.Serialize(subject);
        var cloned = JsonSerializer.Deserialize<Subject>(serialized);

        if (cloned != null) _snapshot?.States?.Add(cloned);
    }

    private void SetScoringType(IEnumerable<Question> questions)
    {
        foreach (var question in questions)
        {
            question.ScoringType = _scoringType?.Get(question.Id);
        }
    }

    private void SetScore(IEnumerable<Question> questions)
    {
        foreach (var question in questions)
        {
            question.Score = Convert.ToByte((question.ScoringType?[question.Answer]).ToString());
        }
    }

    private void SetCategories(IEnumerable<Question> questions)
    {
        foreach (var question in questions)
        {
            question.Categories = _categoryMapFactory!.Get(question.Id);
        }
    }

    private void ProcessRules(
        Subject subject,
        IEnumerable<Question> questions)
    {
        var rules = _ruleFactory!.Create();
        CheckRulesConsistency(rules);
        var stateIndex = _stateCategoryIndex;

        foreach (var rule in rules)
        {
            stateIndex++;
            rule.Output = rule.Calculator?.Calculate(questions);
            subject?.Rules?.Add(rule);

            CloneAndAddToSnapshot(subject!, _states![stateIndex]);
        }
    }
    
    private void SetStates()
    {
        _states = _stateFactory?.Create().ToList();
        _stateCategoryIndex = _states!.FindIndex(x => x.Value == "Categories");
        _stateProfileIndex = _states!.FindIndex(x => x.Value == "Profile");
    }

    private void CheckRulesConsistency(IEnumerable<Rule> rules)
    {
        var expectedRuleCount = _stateProfileIndex - _stateCategoryIndex - 1;

        if (rules.Count() != expectedRuleCount)
        {
            throw new Exception(
                $"Rule factory and state factory are out of sync." +
                $" Expected {expectedRuleCount} rules but found {rules.Count()}");
        }
    }
}
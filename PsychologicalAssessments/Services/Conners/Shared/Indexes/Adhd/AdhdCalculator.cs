using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd;

public class AdhdCalculator : ICalculator
{
    private readonly IAdhdRulesFactory _rulesFactory;

    public AdhdCalculator(IAdhdRulesFactory rulesFactory)
    {
        _rulesFactory = rulesFactory;
    }
    public object Calculate(object input)
    {
        var questions = (List<Question>)input;
        var (hyperActiveRules
            ,inattentiveRules ) = _rulesFactory.Create(questions);
        
        var hyperActiveCount = hyperActiveRules.Count(x => x.IsMatch());
        var inattentiveCount = inattentiveRules.Count(x => x.IsMatch());

        return new AdhdIndex
        {
            HyperActiveIndex = (byte)hyperActiveCount,
            InattentiveIndex = (byte)inattentiveCount
        };
    }
}
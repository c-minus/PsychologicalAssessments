using PsychologicalAssessments.Orchestrator.Base;
using PsychologicalAssessments.Services.Conners.Self.Indexes.Disorder;

namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.Disorder;

public class DisorderCalculator : ICalculator
{
    private readonly IDisorderRulesFactory _rulesFactory;

    public DisorderCalculator(IDisorderRulesFactory rulesFactory)
    {
        _rulesFactory = rulesFactory;
    }
    
    public object Calculate(object input)
    {
        var questions = (List<Question>)input;
        
        var (behaviorRules
            ,oppositionRules ) = _rulesFactory.Create(questions);
        
        var behaviorCount = behaviorRules.Count(x => x.IsMatch());
        var oppositionCount = oppositionRules.Count(x => x.IsMatch());

        return new DisorderIndex
        {
            BehaviorIndex = (byte)behaviorCount,
            OppositionIndex = (byte)oppositionCount
        };
    }
}

   
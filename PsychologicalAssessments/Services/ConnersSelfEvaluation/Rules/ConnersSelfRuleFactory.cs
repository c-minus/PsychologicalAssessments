using PsychologicalAssessments.Orchestrator.Rules;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Adhd;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Inconsistency;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.PiAndNi;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Rules;

public class ConnersSelfRuleFactory : IRuleFactory
{
    public IEnumerable<Rule> Create()
    {
        yield return new()
        {
            Name = "InconsistencyIndex",
            Calculator = new InconsistencyIndexCalculator()
        };
        yield return new()
        {
            Name = "PiandNiIndex",
            Calculator = new PiAndNiIndexCalculator()
        };
        yield return new()
        {
            Name = "AdhdIndex",
            Calculator = new AdhdCalculator()
        };
        
    }
}
using PsychologicalAssessments.Orchestrator.Rules;
using PsychologicalAssessments.Services.Conners.ConnersSelfEvaluation.Indexes.Inconsistency;
using PsychologicalAssessments.Services.Conners.Self.Indexes.Adhd;
using PsychologicalAssessments.Services.Conners.Self.Indexes.Adhd3;
using PsychologicalAssessments.Services.Conners.Self.Indexes.Disorder;
using PsychologicalAssessments.Services.Conners.Self.Indexes.Screening;
using PsychologicalAssessments.Services.Conners.Self.Indexes.SevereBehavior;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd3;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Deterioration;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Disorder;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Inconsistency;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.PiAndNi;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Screening;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.SevereBehavior;

namespace PsychologicalAssessments.Services.Conners.Self.Rules;

public class ConnersSelfRuleFactory : IRuleFactory
{
    public IEnumerable<Rule> Create()
    {
        yield return new()
        {
            Name = "InconsistencyIndex",
            Calculator = new InconsistencyIndexCalculator(
                new ConnersSelfInconsistencyPairFactory(),
                (a, b) => a >= 9 && b >= 2)
        };
        yield return new()
        {
            Name = "PiAndNiIndex",
            Calculator = new PiAndNiIndexCalculator(
                (pi=> pi is 0 or 1 or 2),
                (ni)=> ni is 0 or 1 or 2)
        };
        yield return new()
        {
            Name = "AdhdIndex",
            Calculator = new AdhdCalculator(new ConnersSelfAdhdRulesFactory())
        };
        yield return new()
        {
            Name = "DisorderIndex",
            Calculator = new DisorderCalculator(new ConnersSelfDisorderRulesFactory())
        };
        yield return new()
        {
            Name = "DeteriorationIndex",
            Calculator = new DeteriorationCalculator(new byte[] { 95, 96, 97 })
        };
        yield return new()
        {
            Name = "AdhdConners3Index",
            Calculator = new Adhd3Calculator(new ConnersSelfAdhd3RulesFactory())
        };
        yield return new()
        {
            Name = "ScreeningIndex",
            Calculator = new ScreeningCalculator(new ConnersSelfScreeningMapper())
        };
        yield return new()
        {
            Name = "SevereBehaviorIndex",
            Calculator = new SevereBehaviorCalculator(new ConnersSelfSevereBehaviorMapper())
        };
    }
}
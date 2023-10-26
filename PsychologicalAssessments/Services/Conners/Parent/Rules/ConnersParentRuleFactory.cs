using PsychologicalAssessments.Orchestrator.Rules;
using PsychologicalAssessments.Services.Conners.ConnersParent.Indexes.Inconsistency;
using PsychologicalAssessments.Services.Conners.Parent.Indexes.Adhd;
using PsychologicalAssessments.Services.Conners.Parent.Indexes.Adhd3;
using PsychologicalAssessments.Services.Conners.Parent.Indexes.Disorder;
using PsychologicalAssessments.Services.Conners.Parent.Indexes.Screening;
using PsychologicalAssessments.Services.Conners.Parent.Indexes.SevereBehavior;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd3;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Deterioration;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Disorder;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Inconsistency;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.PiAndNi;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Screening;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.SevereBehavior;

namespace PsychologicalAssessments.Services.Conners.Parent.Rules;

public class ConnersParentRuleFactory : IRuleFactory
{
    public IEnumerable<Rule> Create()
    {
        yield return new()
        {
            Name = "InconsistencyIndex",
            Calculator = new InconsistencyIndexCalculator(
                new ConnersParentInconsistencyPairFactory(),
                (a, b) => a >= 9 && b >= 2)
        };
        yield return new()
        {
            Name = "PiAndNiIndex",
            Calculator = new PiAndNiIndexCalculator(
                (pi => pi is 0 or 1 or 2 or 3),
                (ni) => ni is 0 or 1 or 2)
        };
        yield return new()
        {
            Name = "AdhdIndex",
            Calculator = new AdhdCalculator(new ConnersParentAdhdRulesFactory())
        };
        yield return new()
        {
            Name = "DisorderIndex",
            Calculator = new DisorderCalculator(new ConnersParentDisorderRulesFactory())
        };
        yield return new()
        {
            Name = "DeteriorationIndex",
            Calculator = new DeteriorationCalculator(new byte[] { 106, 107, 108 })
        };
        yield return new()
        {
            Name = "AdhdConners3Index",
            Calculator = new Adhd3Calculator(new ConnersParentAdhd3RulesFactory())
        };
        yield return new()
        {
            Name = "ScreeningIndex",
            Calculator = new ScreeningCalculator(new ConnersParentScreeningMapper())
        };
        yield return new()
        {
            Name = "SevereBehaviorIndex",
            Calculator = new SevereBehaviorCalculator(new ConnersParentSevereBehaviorMapper())
        };
    }
}
using PsychologicalAssessments.Orchestrator.Rules;
using PsychologicalAssessments.Services.Conners.ConnersParent.Indexes.Inconsistency;
using PsychologicalAssessments.Services.Conners.Parent.Indexes.Adhd;
using PsychologicalAssessments.Services.Conners.Self.Indexes.AdhdConners3;
using PsychologicalAssessments.Services.Conners.Self.Indexes.Disorder;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Inconsistency;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.PiAndNi;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Disorder;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Screening;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.SevereBehavior;

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
                (pi=> pi is 0 or 1 or 2 or 3),
                (ni)=> ni is 0 or 1 or 2)
        };
        yield return new()
        {
            Name = "AdhdIndex",
            Calculator = new AdhdCalculator(new ConnersParentAdhdRulesFactory())
        };
        yield return new()
        {
            Name = "DisorderIndex",
            Calculator = new DisorderCalculator()
        };
        yield return new()
        {
            Name = "DeteriorationIndex",
            Calculator = new DisorderCalculator()
        };
        yield return new()
        {
            Name = "AdhdConners3Index",
            Calculator = new AdhdConners3Calculator()
        };
        yield return new()
        {
            Name = "ScreeningIndex",
            Calculator = new ScreeningCalculator()
        };
        yield return new()
        {
            Name = "SevereBehaviorIndex",
            Calculator = new SevereBehaviorCalculator()
        };
    }
}
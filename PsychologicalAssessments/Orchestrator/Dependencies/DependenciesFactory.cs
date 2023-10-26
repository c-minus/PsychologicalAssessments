using PsychologicalAssessments.Orchestrator.Base;
using PsychologicalAssessments.Services.Conners.Self.DataOutput;
using PsychologicalAssessments.Services.Conners.Self.Profiles;
using PsychologicalAssessments.Services.Conners.Self.Rules;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.CategoryMap;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.ScoringType;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.StateFactory;

namespace PsychologicalAssessments.Orchestrator.Dependencies;

public class DependenciesFactory : IDependenciesFactory
{
    public Dependencies Get(ServiceType serviceType)
        => serviceType switch
        {
            ServiceType.ConnersSelf => GetConnersSelfDependencies(),
            _ => throw new NotImplementedException(
                $"ServiceType : { Enum.GetName(typeof(ServiceType), serviceType)} not implemented.")
        };
    
    private Dependencies GetConnersSelfDependencies()
    {
        return new()
        {
            StateFactory = new ConnersSelfStateFactory(),
            ScoringType = new ConnersSelfScoringType(),
            CategoryMapFactory = new ConnersSelfCategoryMapFactory(),
            RuleFactory = new ConnersSelfRuleFactory(),
            ProfileFactory = new ConnersSelfProfileFactory(),
            DataTemplate = new ConnersSelfDataTemplateExcel()
        };
    }
}
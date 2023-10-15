using PsychologicalAssessments.Orchestrator.Base;
using PsychologicalAssessments.Services.ConnersSelfEvaluation;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.CategoryMap;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.ScoringType;

namespace PsychologicalAssessments.Orchestrator.Dependencies;

public class DependenciesFactory : IDependenciesFactory
{
    public Dependencies Get(ServiceType serviceType)
        => serviceType switch
        {
            ServiceType.ConnersSelf => GetConnersSelfDependencies(),
            _ => throw new NotImplementedException()
        };
    
    private Dependencies GetConnersSelfDependencies()
    {
        return new()
        {
            ScoringType = new ConnersSelfScoringType(),
            CategoryMapFactory = new ConnersSelfCategoryMapFactory()
        };
    }
}
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Orchestrator.Dependencies;

public interface IDependenciesFactory
{
    public Dependencies Get(ServiceType serviceType);
}
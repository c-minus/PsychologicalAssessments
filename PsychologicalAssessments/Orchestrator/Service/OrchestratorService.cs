using Microsoft.AspNetCore.Components.Forms;
using PsychologicalAssessments.Orchestrator.Base;
using PsychologicalAssessments.Orchestrator.CategoryMap;
using PsychologicalAssessments.Orchestrator.Dependencies;
using PsychologicalAssessments.Orchestrator.ScoringType;

namespace PsychologicalAssessments.Orchestrator.Service;

public class OrchestratorService : IOrchestratorService
{
    private readonly IDependenciesFactory _dependenciesFactory;
    private IScoringType  _scoringType;
    private ICategoryMapFactory _categoryMapFactory;

    public OrchestratorService
    (
        IDependenciesFactory dependenciesFactory
    )
    {
        _dependenciesFactory = dependenciesFactory;
    }

    public async Task Orchestrate(
        ServiceType serviceType,
        IBrowserFile file)
    {
        SetDependencies(serviceType);
    }
    
    private void SetDependencies(ServiceType serviceType)
    {
        var dependencies = _dependenciesFactory?.Get(serviceType);
        
        _scoringType = dependencies?.ScoringType!;
        _categoryMapFactory = dependencies?.CategoryMapFactory!;
    }
}
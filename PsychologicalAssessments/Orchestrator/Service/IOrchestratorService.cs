using Microsoft.AspNetCore.Components.Forms;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Orchestrator.Service;

public interface IOrchestratorService
{
    public Task Orchestrate(ServiceType serviceType, IBrowserFile file);
}
using Microsoft.AspNetCore.Components.Forms;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation
{
    public interface IConnersSelfEvaluationService
    {
        public Task<Snapshot?> InitAsync(IBrowserFile file);
    }
}


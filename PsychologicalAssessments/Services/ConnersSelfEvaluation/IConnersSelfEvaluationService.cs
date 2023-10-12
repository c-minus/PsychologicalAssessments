using Microsoft.AspNetCore.Components.Forms;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation
{
    public interface IConnersSelfEvaluationService
    {
        public Task<Snapshot?> InitAsync(IBrowserFile file);
    }
}


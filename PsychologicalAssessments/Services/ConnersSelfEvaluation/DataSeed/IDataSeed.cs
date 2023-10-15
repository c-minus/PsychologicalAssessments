using Microsoft.AspNetCore.Components.Forms;
using PsychologicalAssessments.Orchestrator;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.DataSeed
{
    public interface IDataSeed
    {
        public Task<Subject> GetAsync(IBrowserFile file);
    }
}

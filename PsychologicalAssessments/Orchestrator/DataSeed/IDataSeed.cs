using Microsoft.AspNetCore.Components.Forms;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Orchestrator.DataSeed
{
    public interface IDataSeed
    {
        public Task<Subject> GetAsync(IBrowserFile file);
    }
}

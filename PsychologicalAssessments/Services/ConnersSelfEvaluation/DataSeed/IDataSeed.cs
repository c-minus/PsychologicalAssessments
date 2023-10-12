using Microsoft.AspNetCore.Components.Forms;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.DataSeed
{
    public interface IDataSeed
    {
        public Task<Subject> GetAsync(IBrowserFile file);
    }
}

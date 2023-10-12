namespace PsychologicalAssessments.Services.ConnersSelfEvaluation
{
    public interface ICategoryTypeFactory
    {
        public IEnumerable<string> Get(byte id);
    }
}
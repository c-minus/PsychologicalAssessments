namespace PsychologicalAssessments.Orchestrator.CategoryMap
{
    public interface ICategoryMapFactory
    {
        public IEnumerable<string> Get(byte id);
    }
}
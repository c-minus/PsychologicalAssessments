namespace PsychologicalAssessments.Orchestrator.StateFactory;

public interface IStateFactory
{
    public IEnumerable<KeyValuePair<byte,string>> Create();
}
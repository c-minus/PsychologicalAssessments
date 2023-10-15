namespace PsychologicalAssessments.Orchestrator.Base;
public class Snapshot
{
    public List<Subject>? States { get; set; }
    public Exception? Exception { get; set; }
    public byte[] Output { get; set; }

    public Snapshot()
    {
        States = new List<Subject>();
    }
}

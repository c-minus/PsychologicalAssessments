namespace PsychologicalAssessments.Orchestrator.Base;
public class Snapshot
{
    public List<Subject>? States { get; set; } = new();
    public Exception? Exception { get; set; }
    public byte[]? Output { get; set; }
}

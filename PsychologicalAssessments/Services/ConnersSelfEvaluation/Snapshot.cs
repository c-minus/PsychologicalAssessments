namespace PsychologicalAssessments.Services.ConnersSelfEvaluation;
public class Snapshot
{
    public List<Subject>? States { get; set; }
    public Exception? Exception { get; set; }

    public Snapshot()
    {
        States = new List<Subject>();
    }
}

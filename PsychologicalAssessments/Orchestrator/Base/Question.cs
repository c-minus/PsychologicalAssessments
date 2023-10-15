namespace PsychologicalAssessments.Orchestrator.Base;
public class Question
{
    public byte Id { get; set; }
    public byte Answer { get; set; }
    public byte Score { get; set; }
    public string? ScoringType { get; set; }
    public IEnumerable<string>? Categories { get; set; }
}
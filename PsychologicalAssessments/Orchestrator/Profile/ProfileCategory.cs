using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Orchestrator.Profile;

public class ProfileCategory
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public AgeSegment? AgeSegment { get; set; }
    public List<Question> Questions { get; set; } = new();
    public byte Total { get; set; }
}
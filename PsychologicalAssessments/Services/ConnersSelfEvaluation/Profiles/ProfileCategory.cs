using PsychologicalAssessments.Orchestrator;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Profiles;

public class ProfileCategory
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public AgeSegment? AgeSegment { get; set; }
    public List<Question> Questions { get; set; } = new List<Question>();
    public byte Total { get; set; }
}
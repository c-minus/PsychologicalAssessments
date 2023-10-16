using PsychologicalAssessments.Extensions;
using PsychologicalAssessments.Orchestrator.Rules;

namespace PsychologicalAssessments.Orchestrator.Base;
public class Subject
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public KeyValuePair<byte,string> CurrentState { get; set; }
    public byte Age { get; set; }
    public IdentifyAs? GenderInternal => Gender?.GetEnumValueByName<IdentifyAs>();
    public string? Gender { get; set; }
    public List<Question>? Questions { get; set; }
    public List<Rule>? Rules { get; set; } = new();
    public DateTime? CreatedAt { get; } = DateTime.Now;
    public Profile.Profile? Profile { get; set; }
    public Tresult.Tresult? TResult { get; set; }
}
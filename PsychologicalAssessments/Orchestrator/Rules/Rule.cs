using System.Text.Json.Serialization;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Orchestrator.Rules;

public class Rule
{
    public string? Name { get; set; }
    [JsonIgnore] public ICalculator? Calculator { get; set; }
    public object? Output { get; set; }
}
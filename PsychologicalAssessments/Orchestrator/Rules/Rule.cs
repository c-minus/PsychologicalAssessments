namespace PsychologicalAssessments.Orchestrator.Rules;

public class Rule
{
    public string Name { get; set; }
    public ICalculator Calculator { get; set; }
    public object Output { get; set; }
}
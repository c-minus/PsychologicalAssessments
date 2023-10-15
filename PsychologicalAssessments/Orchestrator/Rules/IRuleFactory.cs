namespace PsychologicalAssessments.Orchestrator.Rules;

public interface IRuleFactory
{
    public IEnumerable<Rule> Create();
}
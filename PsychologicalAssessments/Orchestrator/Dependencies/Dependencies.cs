using PsychologicalAssessments.Orchestrator.CategoryMap;
using PsychologicalAssessments.Orchestrator.ScoringType;

namespace PsychologicalAssessments.Orchestrator.Dependencies;

public class Dependencies
{
    public IScoringType? ScoringType { get; set; }
    public ICategoryMapFactory? CategoryMapFactory { get; set; }
}
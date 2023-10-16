using PsychologicalAssessments.Orchestrator.CategoryMap;
using PsychologicalAssessments.Orchestrator.DataOutput;
using PsychologicalAssessments.Orchestrator.Profile;
using PsychologicalAssessments.Orchestrator.Rules;
using PsychologicalAssessments.Orchestrator.ScoringType;
using PsychologicalAssessments.Orchestrator.StateFactory;

namespace PsychologicalAssessments.Orchestrator.Dependencies;

public class Dependencies
{
    public IStateFactory? StateFactory { get; set; }
    public IScoringType? ScoringType { get; set; }
    public ICategoryMapFactory? CategoryMapFactory { get; set; }
    public IRuleFactory? RuleFactory { get; set; }
    public IProfileFactory? ProfileFactory { get; set; }
    public IDataTemplate? DataTemplate { get; set; }
}
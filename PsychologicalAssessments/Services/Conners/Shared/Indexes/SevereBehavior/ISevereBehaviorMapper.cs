using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.SevereBehavior;

public interface ISevereBehaviorMapper
{
    public IEnumerable<KeyValuePair<string, byte>> Get(IEnumerable<Question> questions);
}
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.Screening;

public interface IScreeningMapper
{
    public IEnumerable<KeyValuePair<string, byte>> Get(IEnumerable<Question> questions);
}
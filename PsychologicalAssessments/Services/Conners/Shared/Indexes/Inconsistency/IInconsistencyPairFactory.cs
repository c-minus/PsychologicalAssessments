namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.Inconsistency;

public interface IInconsistencyPairFactory
{
    public IEnumerable<InconsistencyPair> Create();
}
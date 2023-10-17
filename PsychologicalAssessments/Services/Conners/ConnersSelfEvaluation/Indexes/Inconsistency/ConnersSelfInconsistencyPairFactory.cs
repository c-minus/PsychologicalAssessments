using PsychologicalAssessments.Services.Conners.Shared.Indexes.Inconsistency;

namespace PsychologicalAssessments.Services.Conners.ConnersSelfEvaluation.Indexes.Inconsistency;

public class ConnersSelfInconsistencyPairFactory : IInconsistencyPairFactory
{
    public IEnumerable<InconsistencyPair> Create()
        => new List<InconsistencyPair>
        {
            new() { FirstId = 73, SecondId = 85 },
            new() { FirstId = 50, SecondId = 60 },
            new() { FirstId = 81, SecondId = 79 },
            new() { FirstId = 46, SecondId = 90 },
            new() { FirstId = 17, SecondId = 30 },
            new() { FirstId = 56, SecondId = 70 },
            new() { FirstId = 42, SecondId = 63 },
            new() { FirstId = 69, SecondId = 83 },
            new() { FirstId = 43, SecondId = 61 },
            new() { FirstId = 25, SecondId = 38 },
        };
}
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Inconsistency;

namespace PsychologicalAssessments.Services.Conners.ConnersParent.Indexes.Inconsistency;

public class ConnersParentInconsistencyPairFactory : IInconsistencyPairFactory
{
    public IEnumerable<InconsistencyPair> Create()
        => new List<InconsistencyPair>
        {
            new() { FirstId = 44, SecondId = 67 },
            new() { FirstId = 12, SecondId = 23 },
            new() { FirstId = 36, SecondId = 60 },
            new() { FirstId = 14, SecondId = 81 },
            new() { FirstId = 19, SecondId = 98 },
            new() { FirstId = 45, SecondId = 99 },
            new() { FirstId = 94, SecondId = 102 },
            new() { FirstId = 75, SecondId = 79 },
            new() { FirstId = 13, SecondId = 92 },
            new() { FirstId = 39, SecondId = 83 },
        };
}
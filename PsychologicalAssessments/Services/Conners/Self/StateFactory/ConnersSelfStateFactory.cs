using PsychologicalAssessments.Orchestrator.StateFactory;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.StateFactory;

public class ConnersSelfStateFactory : IStateFactory
{
    public IEnumerable<KeyValuePair<byte, string>> Create()
        => new[]
        {
            new KeyValuePair<byte, string>(1, "InitialData"),
            new KeyValuePair<byte, string>(2, "ScoringType"),
            new KeyValuePair<byte, string>(3, "Score"),
            new KeyValuePair<byte, string>(4, "Categories"),
            new KeyValuePair<byte, string>(5, "InconsistencyIndex"),
            new KeyValuePair<byte, string>(6, "PiAndNiIndex"),
            new KeyValuePair<byte, string>(7, "AdhdIndex"),
            new KeyValuePair<byte, string>(8, "DisorderIndex"),
            new KeyValuePair<byte, string>(9, "DeteriorationIndex"),
            new KeyValuePair<byte, string>(10, "AdhdConners3Index"),
            new KeyValuePair<byte, string>(11, "ScreeningIndex"),
            new KeyValuePair<byte, string>(12, "SevereBehaviorIndex"),
            new KeyValuePair<byte, string>(13, "Profile"),
            new KeyValuePair<byte, string>(14, "Result")
        };
}
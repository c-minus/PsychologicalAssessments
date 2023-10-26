using PsychologicalAssessments.Orchestrator.Base;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.SevereBehavior;

namespace PsychologicalAssessments.Services.Conners.Self.Indexes.SevereBehavior;

public class ConnersSelfSevereBehaviorMapper : ISevereBehaviorMapper
{
    public IEnumerable<KeyValuePair<string, byte>> Get(IEnumerable<Question> questions)
        => new[]
        {
            new KeyValuePair<string, byte>("AnimalCrueltyScore",
                questions.FirstOrDefault(q => q.Id == 47)!.Score),
            new KeyValuePair<string, byte>("BreakingAndEnteringScore",
                questions.FirstOrDefault(q => q.Id == 78)!.Score),
            new KeyValuePair<string, byte>("ConfrontationalTheftScore",
                questions.FirstOrDefault(q => q.Id == 13)!.Score),
            new KeyValuePair<string, byte>("FireStarterScore",
                questions.FirstOrDefault(q => q.Id == 72)!.Score),
            new KeyValuePair<string, byte>("PoliceProblemsOrForcedSexScore",
                questions.FirstOrDefault(q => q.Id == 22)!.Score),
            new KeyValuePair<string, byte>("UsingGunsScore",
                questions.FirstOrDefault(q => q.Id == 59)!.Score)
        };
}
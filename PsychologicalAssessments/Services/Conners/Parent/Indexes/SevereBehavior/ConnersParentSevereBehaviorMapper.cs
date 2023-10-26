using PsychologicalAssessments.Orchestrator.Base;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.SevereBehavior;

namespace PsychologicalAssessments.Services.Conners.Parent.Indexes.SevereBehavior;

public class ConnersParentSevereBehaviorMapper : ISevereBehaviorMapper
{
    public IEnumerable<KeyValuePair<string, byte>> Get(IEnumerable<Question> questions)
        => new[]
        {
            new KeyValuePair<string, byte>("AnimalCrueltyScore",
                questions.FirstOrDefault(q => q.Id == 41)!.Score),
            new KeyValuePair<string, byte>("BreakingAndEnteringScore",
                questions.FirstOrDefault(q => q.Id == 78)!.Score),
            new KeyValuePair<string, byte>("ConfrontationalTheftScore",
                questions.FirstOrDefault(q => q.Id == 78)!.Score),
            new KeyValuePair<string, byte>("FireStarterScore",
                questions.FirstOrDefault(q => q.Id == 72)!.Score),
            new KeyValuePair<string, byte>("PoliceProblemsOrForcedSexScore",
                questions.FirstOrDefault(q => q.Id == 11)!.Score),
            new KeyValuePair<string, byte>("UsingGunsScore",
                questions.FirstOrDefault(q => q.Id == 27)!.Score),
        };
}
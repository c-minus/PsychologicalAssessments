using PsychologicalAssessments.Orchestrator.Base;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Screening;

namespace PsychologicalAssessments.Services.Conners.Self.Indexes.Screening;

public class ConnersSelfScreeningMapper : IScreeningMapper
{
    public IEnumerable<KeyValuePair<string, byte>> Get(IEnumerable<Question> questions)
        => new[]
        {
            new KeyValuePair<string, byte>("IrritableScore",
                questions.FirstOrDefault(q => q.Id == 29)!.Score),
            new KeyValuePair<string, byte>("NervousOrAgitatedScore",
                questions.FirstOrDefault(q => q.Id == 2)!.Score),
            new KeyValuePair<string, byte>("WorriedControlScore",
                questions.FirstOrDefault(q => q.Id == 46)!.Score),
            new KeyValuePair<string, byte>("WorriedScore",
                questions.FirstOrDefault(q => q.Id == 90)!.Score),
            new KeyValuePair<string, byte>("LostOfInterestOrPleasureScore",
                questions.FirstOrDefault(q => q.Id == 44)!.Score),
            new KeyValuePair<string, byte>("SadnessOrIrritableScore",
                questions.FirstOrDefault(q => q.Id == 68)!.Score),
            new KeyValuePair<string, byte>("TiredOrLowEnergyScore",
                questions.FirstOrDefault(q => q.Id == 80)!.Score),
            new KeyValuePair<string, byte>("UselessnessScore",
                questions.FirstOrDefault(q => q.Id == 36)!.Score)
        };
}
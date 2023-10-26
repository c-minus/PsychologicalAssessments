using PsychologicalAssessments.Orchestrator.Base;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Screening;

namespace PsychologicalAssessments.Services.Conners.Parent.Indexes.Screening;

public class ConnersParentScreeningMapper : IScreeningMapper
{
    public IEnumerable<KeyValuePair<string, byte>> Get(IEnumerable<Question> questions)
        => new[]
        {
            new KeyValuePair<string, byte>("IrritableScore",
                questions.FirstOrDefault(q => q.Id == 100)!.Score),
            new KeyValuePair<string, byte>("NervousOrAgitatedScore",
                questions.FirstOrDefault(q => q.Id == 70)!.Score),
            new KeyValuePair<string, byte>("WorriedControlScore",
                questions.FirstOrDefault(q => q.Id == 20)!.Score),
            new KeyValuePair<string, byte>("WorriedScore",
                questions.FirstOrDefault(q => q.Id == 4)!.Score),
            
            new KeyValuePair<string, byte>("LostOfInterestOrPleasureScore",
                questions.FirstOrDefault(q => q.Id == 82)!.Score),
            new KeyValuePair<string, byte>("SadnessOrIrritableScore",
                questions.FirstOrDefault(q => q.Id == 103)!.Score),
            new KeyValuePair<string, byte>("TiredOrLowEnergyScore",
                questions.FirstOrDefault(q => q.Id == 66)!.Score),
            new KeyValuePair<string, byte>("UselessnessScore",
                questions.FirstOrDefault(q => q.Id == 17)!.Score)
        };
}
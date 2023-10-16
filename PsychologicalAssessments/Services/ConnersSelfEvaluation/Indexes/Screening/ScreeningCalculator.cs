using PsychologicalAssessments.Orchestrator;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Screening;

public class ScreeningCalculator : ICalculator
{
    public object Calculate(object input)
    {
        var questions = (List<Question>)input;
        
        var anxietyIndex = new AnxietyIndex
        {
            IrritableScore = questions.FirstOrDefault(q => q.Id == 29)!.Score,
            NervousOrAgitatedScore = questions.FirstOrDefault(q => q.Id == 2)!.Score,
            WorriedControlScore = questions.FirstOrDefault(q => q.Id == 46)!.Score,
            WorriedScore = questions.FirstOrDefault(q => q.Id == 90)!.Score
        };

        var depressionIndex = new DepressionIndex
        {
            LostOfInterestOrPleasureScore = questions.FirstOrDefault(q => q.Id == 44)!.Score,
            SadnessOrIrritableScore = questions.FirstOrDefault(q => q.Id == 68)!.Score,
            TiredOrLowEnergyScore = questions.FirstOrDefault(q => q.Id == 80)!.Score,
            UselessnessScore = questions.FirstOrDefault(q => q.Id == 36)!.Score
        };

        var screeningIndex = new ScreeningIndex
        {
            AnxietyIndex = anxietyIndex,
            DepressionIndex = depressionIndex
        };

        return screeningIndex;
    }
}
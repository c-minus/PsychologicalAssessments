using PsychologicalAssessments.Orchestrator;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.SevereBehavior;

public class SevereBehaviorCalculator : ICalculator
{
    public object Calculate(object input)
    {
        var questions = (List<Question>)input;

        return new SevereBehaviorIndex
        {
            AnimalCrueltyScore = questions.FirstOrDefault(q => q.Id == 47)!.Score,
            BreakingAndEnteringScore = questions.FirstOrDefault(q => q.Id == 78)!.Score,
            ConfrontationalTheftScore = questions.FirstOrDefault(q => q.Id == 13)!.Score,
            FireStarterScore = questions.FirstOrDefault(q => q.Id == 72)!.Score,
            PoliceProblemsScore = questions.FirstOrDefault(q => q.Id == 22)!.Score,
            UsingGunsScore = questions.FirstOrDefault(q => q.Id == 59)!.Score
        };
    }
}
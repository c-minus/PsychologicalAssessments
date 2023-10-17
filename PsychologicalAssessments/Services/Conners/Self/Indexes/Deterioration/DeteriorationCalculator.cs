using PsychologicalAssessments.Orchestrator;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Deterioration;

public class DeteriorationCalculator : ICalculator
{
    public object Calculate(object input)
    {
       var questions = (List<Question>)input;

       return new DeteriorationIndex
       {
           School = questions.FirstOrDefault(q => q.Id == 95)!.Score,
           Home = questions.FirstOrDefault(q => q.Id == 97)!.Score,
           Friends = questions.FirstOrDefault(q => q.Id == 96)!.Score
       };
    }
}
using PsychologicalAssessments.Orchestrator;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.PiAndNi;

public class PiAndNiIndexCalculator : ICalculator
{
    public object Calculate(object input)
    {
        var questions = (List<Question>)input;
        
        var pi = questions.Where(q => q.Categories != null && q.Categories.Contains("PI")).Sum(q => q.Score);
        var ni = questions.Where(q => q.Categories != null && q.Categories.Contains("NI")).Sum(q => q.Score);

        return new PiAndNiIndex
        {
            Pi = (byte)pi,
            Ni = (byte)ni
        };
    }
}

using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Orchestrator.Tresult;

public class TresultCalculator : ITresultCalculator
{
    public Tresult? Calculate(Subject subject)
    {
        return new Tresult()
        {
            Items = GetResultT(subject).ToList(),
        };
    }
    
    private IEnumerable<ResultCategory> GetResultT(Subject subject)
    {
        foreach (var profileCategory in subject?.Profile?.Categories!)
        {
            var questions = subject?.Questions!
                .Where(q => q.Categories!.Contains(profileCategory.Id));
            var totalValue = questions?.Sum(q => q.Score);

            profileCategory.Questions = questions!.ToList();
            profileCategory.Total = (byte)totalValue!;

            var mappings = profileCategory?.AgeSegment?.Mappings;
            var max = mappings!.MaxBy(kvp => kvp.Key).Key;
            totalValue = totalValue > max ? max : totalValue;

            var scoreT = mappings!.FirstOrDefault(a => a.Key == totalValue).Value;

            yield return new ResultCategory()
            {
                Id = profileCategory!.Id,
                Name = profileCategory.Name,
                Value = scoreT
            };
        }
    }
}
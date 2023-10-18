using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.Deterioration;

public class DeteriorationCalculator : ICalculator
{
    private readonly byte[] _map;

    public DeteriorationCalculator(byte[] map)
    {
        _map = map;
    }

    public object Calculate(object input)
    {
        var questions = (List<Question>)input;

        return new DeteriorationIndex
        {
            School = questions.FirstOrDefault(q => q.Id == _map[0])!.Score,
            Friends = questions.FirstOrDefault(q => q.Id == _map[1])!.Score,
            Home = questions.FirstOrDefault(q => q.Id == _map[2])!.Score
        };
    }
}
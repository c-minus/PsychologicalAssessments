using PsychologicalAssessments.Orchestrator;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Inconsistency
{
    public class InconsistencyIndexCalculator : ICalculator
    {
        public object Calculate(object input)
        {
            var questions = (List<Question>)input;
            var pairs = GetPairs();

            foreach (var pair in pairs)
            {
                pair.FirstValue = questions.FirstOrDefault(q => q.Id == pair.FirstId)?.Score ?? default;
                pair.SecondValue = questions.FirstOrDefault(q => q.Id == pair.SecondId)?.Score ?? default;
            }

            var a = pairs.Sum(p => p.FinalValue);
            var b = pairs
                .Where(p => p.FinalValue is 2 or 3)
                .Sum(p => p.FinalValue);

            var index = new InconsistencyIndex
            {
                A = (byte)a,
                B = (byte)b,
            };

            return index;
        }

        private IEnumerable<InconsistencyPair> GetPairs()
        {
            return new List<InconsistencyPair>
            {
                new() { FirstId = 73, SecondId = 85 },
                new() { FirstId = 50, SecondId = 60 },
                new() { FirstId = 81, SecondId = 79 },
                new() { FirstId = 46, SecondId = 90 },
                new() { FirstId = 17, SecondId = 30 },
                new() { FirstId = 56, SecondId = 70 },
                new() { FirstId = 42, SecondId = 63 },
                new() { FirstId = 69, SecondId = 83 },
                new() { FirstId = 43, SecondId = 61 },
                new() { FirstId = 25, SecondId = 38 },
            };
        }
        
        public InconsistencyIndex Calculate(List<Question> questions)
        {
            throw new NotImplementedException();
        }
    }
}
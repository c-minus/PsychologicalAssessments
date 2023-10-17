using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.Inconsistency
{
    public class InconsistencyIndexCalculator : ICalculator
    {
        private readonly IInconsistencyPairFactory _pairFactory;
        private readonly Func<byte, byte, bool> _isProbablyInvalid;

        public InconsistencyIndexCalculator(
            IInconsistencyPairFactory pairFactory,
            Func<byte,byte,bool> isProbablyInvalid)
        {
            _pairFactory = pairFactory;
            _isProbablyInvalid = isProbablyInvalid;
        }
        public object Calculate(object input)
        {
            var questions = (List<Question>)input;
            var pairs = _pairFactory.Create().ToList();

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
                IsProbablyInvalid = _isProbablyInvalid((byte)a, (byte)b)
            };

            return index;
        }
    }
}
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.PiAndNi;

public class PiAndNiIndexCalculator : ICalculator
{
    private readonly Func<byte, bool> _isProbablyValidPi;
    private readonly Func<byte, bool> _isProbablyValidNi;
    public PiAndNiIndexCalculator(
        Func<byte, bool> isProbablyValidPi,
        Func<byte, bool> isProbablyValidNi)
    {
        _isProbablyValidPi = isProbablyValidPi;
        _isProbablyValidNi = isProbablyValidNi;
    }
    public object Calculate(object input)
    {
        var questions = (List<Question>)input;
        
        var pi = questions.Where(q => q.Categories != null && q.Categories.Contains("PI")).Sum(q => q.Score);
        var ni = questions.Where(q => q.Categories != null && q.Categories.Contains("NI")).Sum(q => q.Score);

        return new PiAndNiIndex
        {
            Pi = (byte)pi,
            Ni = (byte)ni,
            IsProbablyValidPi = _isProbablyValidPi((byte)pi),
            IsProbablyValidNi = _isProbablyValidNi((byte)ni)
        };
    }
}

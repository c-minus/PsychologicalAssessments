using PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd3;

namespace PsychologicalAssessments.Services.Conners.Self.Indexes.Adhd3;

public class ConnersSelfAdhd3RulesFactory : IAdhd3RuleFactory
{
    public Tuple<IEnumerable<Adhd3Rule>, Func<byte, byte>> Create()
        => new(GetRules(), GetProbability);

    private IEnumerable<Adhd3Rule> GetRules()
    {
        yield return new Adhd3Rule
        {
            Ids = new List<byte> { 6, 9, 15, 21, 43, 63 },
            Func = Adhd3Calculator.TransformTypeOne
        };

        yield return new Adhd3Rule
        {
            Ids = new List<byte> { 34, 50 },
            Func = Adhd3Calculator.TransformTypeTwo
        };

        yield return new Adhd3Rule
        {
            Ids = new List<byte> { 35, 61 },
            Func = Adhd3Calculator.TransformTypeThree
        };
    }

    private byte GetProbability(byte totalScore)
        =>
            totalScore switch
            {
                0 => 26,
                1 => 35,
                2 => 44,
                3 => 52,
                4 => 59,
                5 => 66,
                6 => 73,
                7 => 78,
                8 => 83,
                9 => 87,
                10 => 91,
                11 => 94,
                12 => 96,
                13 => 97,
                14 or 15 => 98,
                16 or 17 or 18 => 99,
                _ => throw new Exception($"Invalid score: {totalScore}, expected between zero and eighteen.")
            };
}
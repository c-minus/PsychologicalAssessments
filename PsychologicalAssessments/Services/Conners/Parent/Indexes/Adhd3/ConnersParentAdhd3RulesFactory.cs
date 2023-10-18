using PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd3;

namespace PsychologicalAssessments.Services.Conners.Parent.Indexes.Adhd3;

public class ConnersParentAdhd3RulesFactory : IAdhd3RuleFactory
{
    public Tuple<IEnumerable<Adhd3Rule>, Func<byte, byte>> Create()
        => new(GetRules(), GetProbability);

    private IEnumerable<Adhd3Rule> GetRules()
    {
        yield return new Adhd3Rule
        {
            Ids = new List<byte> { 19, 47, 67, 84, 99, 101, 104 },
            Func = Adhd3Calculator.TransformTypeOne
        };

        yield return new Adhd3Rule
        {
            Ids = new List<byte> { 35, 88, 98 },
            Func = Adhd3Calculator.TransformTypeThree
        };
    }

    private byte GetProbability(byte totalScore)
        =>
            totalScore switch
            {
                0 => 11,
                1 => 29,
                2 => 41,
                3 => 51,
                4 => 56,
                5 => 64,
                6 => 71,
                7 => 77,
                8 => 82,
                9 => 87,
                10 => 91,
                11 => 94,
                12 => 97,
                13 => 98,
                14 or 15 or 16 or 17 or 18 or 19 or 20 => 99,
                _ => throw new Exception($"Invalid score: {totalScore}, expected between zero and twenty.")
            };
}
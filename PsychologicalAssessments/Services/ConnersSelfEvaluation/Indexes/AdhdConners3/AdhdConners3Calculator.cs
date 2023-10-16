using PsychologicalAssessments.Orchestrator;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.AdhdConners3;

public class AdhdConners3Calculator : ICalculator
{
    private readonly IEnumerable<AdhdConners3Rule> _rules;

    public AdhdConners3Calculator()
    {
        _rules = GetRules();
    }

    public object Calculate(object input)
    {
        var questions = (List<Question>)input;
        var items = new List<KeyValuePair<byte, byte>>();

        foreach (var rule in _rules)
        {
            foreach (var id in rule.Ids!)
            {
                var question = questions.FirstOrDefault(x => x.Id == id);

                if (question == null)
                {
                    throw new Exception($"Question with id {id} not found.");
                }

                rule.Apply(question.Score);
                items.Add(new KeyValuePair<byte, byte>(id, rule.Score));
            }
        }
        
        var totalScore = (byte)items.Sum(x => x.Value);

        return new AdhdConners3Index
        {
            Items = items,
            TotalScore = totalScore,
            Probability = GetProbability(totalScore)
        };
    }

    private IEnumerable<AdhdConners3Rule> GetRules()
    {
        yield return new AdhdConners3Rule
        {
            Ids = new List<byte> { 6, 9, 15, 21, 43, 63 },
            Func = TransformTypeOne
        };

        yield return new AdhdConners3Rule
        {
            Ids = new List<byte> { 34, 50 },
            Func = TransformTypeTwo
        };

        yield return new AdhdConners3Rule
        {
            Ids = new List<byte> { 35, 61 },
            Func = TransformTypeThree
        };
    }

    private byte TransformTypeOne(byte initialScore)
    {
        return initialScore switch
        {
            0 or 1 => 0,
            2 => 1,
            3 => 2,
            _ => throw new Exception($"Invalid score: {initialScore}, expected between one and three.")
        };
    }

    private byte TransformTypeTwo(byte initialScore)
    {
        return initialScore switch
        {
            0 or 1 => 0,
            2 or 3 => 1,
            _ => throw new Exception($"Invalid score: {initialScore}, expected between one and three.")
        };
    }

    private byte TransformTypeThree(byte initialScore)
    {
        return initialScore switch
        {
            0 or 1 => 0,
            2 or 3 => 2,
            _ => throw new Exception($"Invalid score: {initialScore}, expected between one and three.")
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
                _ => 0
            };
}
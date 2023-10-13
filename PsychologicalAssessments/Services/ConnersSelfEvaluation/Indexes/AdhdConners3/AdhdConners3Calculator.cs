namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.AdhdConners3;

public class AdhdConners3Calculator : IAdhdConners3Calculator
{
    private readonly IEnumerable<AdhdConners3Rule> _rules;

    public AdhdConners3Calculator()
    {
        _rules = GetRules();
    }

    public AdhdConners3Index Calculate(List<Question> questions)
    {
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

        return new AdhdConners3Index
        {
            Items = items
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
}
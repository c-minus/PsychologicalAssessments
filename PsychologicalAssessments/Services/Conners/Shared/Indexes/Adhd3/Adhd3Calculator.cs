using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd3;

public class Adhd3Calculator : ICalculator
{
    private readonly IEnumerable<Adhd3Rule> _rules;
    private readonly Func<byte,byte> _probabilityFunc;
    private readonly IAdhd3RuleFactory _ruleFactory;

    public Adhd3Calculator(IAdhd3RuleFactory ruleFactory)
    {
        _ruleFactory = ruleFactory;
        var (rules, probabilityFunc)= _ruleFactory.Create();
        _rules = rules;
        _probabilityFunc = probabilityFunc;
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

        return new Adhd3Index
        {
            Items = items,
            TotalScore = totalScore,
            Probability = _probabilityFunc(totalScore)
        };
    }
    
    public static byte TransformTypeOne(byte initialScore)
    {
        return initialScore switch
        {
            0 or 1 => 0,
            2 => 1,
            3 => 2,
            _ => throw new Exception($"Invalid score: {initialScore}, expected between one and three.")
        };
    }

    public static byte TransformTypeTwo(byte initialScore)
    {
        return initialScore switch
        {
            0 or 1 => 0,
            2 or 3 => 1,
            _ => throw new Exception($"Invalid score: {initialScore}, expected between one and three.")
        };
    }

    public static byte TransformTypeThree(byte initialScore)
    {
        return initialScore switch
        {
            0 or 1 => 0,
            2 or 3 => 2,
            _ => throw new Exception($"Invalid score: {initialScore}, expected between one and three.")
        };
    }
}
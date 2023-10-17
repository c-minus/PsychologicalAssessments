using PsychologicalAssessments.Orchestrator.Base;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd;

namespace PsychologicalAssessments.Services.Conners.Parent.Indexes.Adhd;

public class ConnersParentAdhdRulesFactory : IAdhdRulesFactory
{
    public Tuple<IEnumerable<AdhdRule>, IEnumerable<AdhdRule>> Create(IEnumerable<Question> questions)
        => new(GetHyperActiveRules(questions), GetInattentiveRules(questions));
    
    private IEnumerable<AdhdRule> GetHyperActiveRules(IEnumerable<Question> questions)
    {
        yield return new ()
        {
            Name = "A2a",
            Value1 = questions.FirstOrDefault(x => x.Id == 98)!.Score,
        };
        yield return new ()
        {
            Name = "A2b",
            Value1 = questions.FirstOrDefault(x => x.Id == 93)!.Score,
        };
        yield return new ()
        {
            Name = "A2c",
            Value1 = questions.FirstOrDefault(x => x.Id == 69)!.Score,
            Value2 = questions.FirstOrDefault(x => x.Id == 99)?.Score,
            Predicate = (value1, value2) => value1 is 1 or 2 or 3 || value2 is 1 or 2 or 3
        };
        yield return new ()
        {
            Name = "A2d",
            Value1 = questions.FirstOrDefault(x => x.Id == 71)!.Score
        };
        yield return new ()
        {
            Name = "A2e",
            Value1 = questions.FirstOrDefault(x => x.Id == 54)!.Score,
            Value2 = questions.FirstOrDefault(x => x.Id == 45)?.Score,
            Predicate = (value1, value2) => value1 is 1 or 2 or 3 || value2 is 1 or 2 or 3
        };
        yield return new ()
        {
            Name = "A2f",
            Value1 = questions.FirstOrDefault(x => x.Id == 3)!.Score
        };
        yield return new ()
        {
            Name = "A2g",
            Value1 = questions.FirstOrDefault(x => x.Id == 43)!.Score
        };
        yield return new ()
        {
            Name = "A2h",
            Value1 = questions.FirstOrDefault(x => x.Id == 61)!.Score
        };
        yield return new ()
        {
            Name = "A2i",
            Value1 = questions.FirstOrDefault(x => x.Id == 104)!.Score
        };
    }
    private IEnumerable<AdhdRule> GetInattentiveRules(IEnumerable<Question> questions)
    {
        yield return new ()
        {
            Name = "A1a",
            Value1 = questions.FirstOrDefault(x => x.Id == 47)!.Score
        };
        yield return new ()
        {
            Name = "A1b",
            Value1 = questions.FirstOrDefault(x => x.Id == 95)!.Score
        };
        yield return new ()
        {
            Name = "A1c",
            Value1 = questions.FirstOrDefault(x => x.Id == 35)!.Score,
        };
        yield return new ()
        {
            Name = "A1d",
            Value1 = questions.FirstOrDefault(x => x.Id == 68)!.Score,
            Value2 = questions.FirstOrDefault(x => x.Id == 79)?.Score,
            Predicate = (value1, value2) => value1 is 2 or 3 && value2 is 2 or 3
        };
        yield return new ()
        {
            Name = "A1e",
            Value1 = questions.FirstOrDefault(x => x.Id == 84)!.Score,
        };
        yield return new ()
        {
            Name = "A1f",
            Value1 = questions.FirstOrDefault(x => x.Id == 28)!.Score,
        };
        yield return new ()
        {
            Name = "A1g",
            Value1 = questions.FirstOrDefault(x => x.Id == 97)!.Score,
        };
        yield return new ()
        {
            Name = "A1h",
            Value1 = questions.FirstOrDefault(x => x.Id == 101)!.Score,
        };
        yield return new ()
        {
            Name = "A1i",
            Value1 = questions.FirstOrDefault(x => x.Id == 2)!.Score,
        };
    }
}
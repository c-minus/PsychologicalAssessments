using PsychologicalAssessments.Orchestrator.Base;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd;

namespace PsychologicalAssessments.Services.Conners.Self.Indexes.Adhd;

public class ConnersSelfAdhdRulesFactory : IAdhdRulesFactory
{
    public Tuple<IEnumerable<AdhdRule>, IEnumerable<AdhdRule>> Create(IEnumerable<Question> questions)
        => new(GetHyperActiveRules(questions), GetInattentiveRules(questions));

    private IEnumerable<AdhdRule> GetHyperActiveRules(IEnumerable<Question> questions)
    {
        yield return new AdhdRule()
        {
            Name = "A2a",
            Value1 = questions.FirstOrDefault(x => x.Id == 60)!.Score,
            Value2 = null,
            Predicate = (value1, value2) => value1 is 2 or 3
        };

        yield return new AdhdRule()
        {
            Name = "A2b",
            Value1 = questions.FirstOrDefault(x => x.Id == 64)!.Score,
            Value2 = null,
            Predicate = (value1, value2) => value1 is 2 or 3
        };

        yield return new AdhdRule()
        {
            Name = "A2c",
            Value1 = questions.FirstOrDefault(x => x.Id == 20)!.Score,
            Value2 = questions.FirstOrDefault(x => x.Id == 7)?.Score,
            Predicate = (value1, value2) => value1 == 2 || value1 == 3 || value2 == 2 || value2 == 3
        };

        yield return new AdhdRule()
        {
            Name = "A2d",
            Value1 = questions.FirstOrDefault(x => x.Id == 84)!.Score,
            Value2 = null,
            Predicate = (value1, value2) => value1 is 2 or 3
        };

        yield return new AdhdRule()
        {
            Name = "A2e",
            Value1 = questions.FirstOrDefault(x => x.Id == 66)!.Score,
            Value2 = questions.FirstOrDefault(x => x.Id == 55)?.Score,
            Predicate = (value1, value2) => value1 is 1 or 2 or 3 || value2 is 2 or 3
        };

        yield return new AdhdRule()
        {
            Name = "A2f",
            Value1 = questions.FirstOrDefault(x => x.Id == 34)!.Score,
            Value2 = null,
            Predicate = (value1, value2) => value1 is 2 or 3
        };

        yield return new AdhdRule()
        {
            Name = "A2g",
            Value1 = questions.FirstOrDefault(x => x.Id == 9)!.Score,
            Value2 = null,
            Predicate = (value1, value2) => value1 is 2 or 3
        };

        yield return new AdhdRule()
        {
            Name = "A2h",
            Value1 = questions.FirstOrDefault(x => x.Id == 27)!.Score,
            Value2 = null,
            Predicate = (value1, value2) => value1 == 2 || value1 == 3
        };

        yield return new AdhdRule()
        {
            Name = "A2i",
            Value1 = questions.FirstOrDefault(x => x.Id == 6)!.Score,
            Value2 = null,
            Predicate = (value1, value2) => value1 is 2 or 3
        };
    }
    private IEnumerable<AdhdRule> GetInattentiveRules(IEnumerable<Question> questions)
    {
        yield return new AdhdRule()
        {
            Name = "A1a",
            Value1 = questions.FirstOrDefault(x => x.Id == 31)!.Score,
            Value2 = questions.FirstOrDefault(x => x.Id == 39)?.Score,
            Predicate = (value1, value2) => value1 is 2 or 3 || value2 is 2 or 3
        };

        yield return new AdhdRule()
        {
            Name = "A1b",
            Value1 = questions.FirstOrDefault(x => x.Id == 63)!.Score,
            Value2 = null,
            Predicate = (value1, value2) => value1 is 2 or 3
        };

        yield return new AdhdRule()
        {
            Name = "A1c",
            Value1 = questions.FirstOrDefault(x => x.Id == 42)!.Score,
            Value2 = null,
            Predicate = (value1, value2) => value1 is 2 or 3
        };

        yield return new AdhdRule()
        {
            Name = "A1d",
            Value1 = questions.FirstOrDefault(x => x.Id == 61)!.Score,
            Value2 = questions.FirstOrDefault(x => x.Id == 17)?.Score,
            Predicate = (value1, value2) => value1 is 2 or 3 && value2 is 2 or 3
        };

        yield return new AdhdRule()
        {
            Name = "A1e",
            Value1 = questions.FirstOrDefault(x => x.Id == 21)!.Score,
            Value2 = null,
            Predicate = (value1, value2) => value1 is 2 or 3
        };

        yield return new AdhdRule()
        {
            Name = "A1f",
            Value1 = questions.FirstOrDefault(x => x.Id == 51)!.Score,
            Value2 = null,
            Predicate = (value1, value2) => value1 is 2 or 3
        };

        yield return new AdhdRule()
        {
            Name = "A1g",
            Value1 = questions.FirstOrDefault(x => x.Id == 5)!.Score,
            Value2 = null,
            Predicate = (value1, value2) => value1 is 2 or 3
        };

        yield return new AdhdRule()
        {
            Name = "A1h",
            Value1 = questions.FirstOrDefault(x => x.Id == 77)!.Score,
            Value2 = null,
            Predicate = (value1, value2) => value1 is 2 or 3
        };

        yield return new AdhdRule()
        {
            Name = "A1i",
            Value1 = questions.FirstOrDefault(x => x.Id == 32)!.Score,
            Value2 = null,
            Predicate = (value1, value2) => value1 is 2 or 3
        };
    }
}
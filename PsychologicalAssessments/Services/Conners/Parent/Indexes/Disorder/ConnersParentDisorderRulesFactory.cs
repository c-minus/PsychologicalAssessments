using PsychologicalAssessments.Orchestrator.Base;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Disorder;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Disorder;

namespace PsychologicalAssessments.Services.Conners.Parent.Indexes.Disorder;

public class ConnersParentDisorderRulesFactory : IDisorderRulesFactory
{
    public Tuple<IEnumerable<DisorderRule>, IEnumerable<DisorderRule>> Create(IEnumerable<Question> questions)
        => new(GetBehaviorRules(questions), GetOppositionRules(questions));

    private IEnumerable<DisorderRule> GetBehaviorRules(IEnumerable<Question> questions)
    {
        yield return new DisorderRule()
        {
            Name = "A1",
            Value = questions.FirstOrDefault(x => x.Id == 16)!.Score
        };
        yield return new DisorderRule()
        {
            Name = "A2",
            Value = questions.FirstOrDefault(x => x.Id == 30)!.Score
        };
        yield return new DisorderRule()
        {
            Name = "A3",
            Value = questions.FirstOrDefault(x => x.Id == 27)!.Score
        };
        yield return new DisorderRule()
        {
            Name = "A4",
            Value = questions.FirstOrDefault(x => x.Id == 39)!.Score
        };
        yield return new DisorderRule()
        {
            Name = "A5",
            Value = questions.FirstOrDefault(x => x.Id == 41)!.Score
        };
        yield return new DisorderRule()
        {
            Name = "A6",
            Value = questions.FirstOrDefault(x => x.Id == 96)!.Score
        };
        yield return new DisorderRule()
        {
            Name = "A7",
            Value = questions.FirstOrDefault(x => x.Id == 11)!.Score
        };
        yield return new DisorderRule()
        {
            Name = "A8",
            Value = questions.FirstOrDefault(x => x.Id == 78)!.Score
        };
        yield return new DisorderRule()
        {
            Name = "A9",
            Value = questions.FirstOrDefault(x => x.Id == 65)!.Score
        };
        yield return new DisorderRule()
        {
            Name = "A10",
            Value = questions.FirstOrDefault(x => x.Id == 89)!.Score
        };
        yield return new DisorderRule()
        {
            Name = "A11",
            Value = questions.FirstOrDefault(x => x.Id == 56)!.Score,
            Predicate = (value) => value is 2 or 3
        };
        yield return new DisorderRule()
        {
            Name = "A12",
            Value = questions.FirstOrDefault(x => x.Id == 58)!.Score
        };
        yield return new DisorderRule()
        {
            Name = "A13",
            Value = questions.FirstOrDefault(x => x.Id == 91)!.Score
        };
        yield return new DisorderRule()
        {
            Name = "A14",
            Value = questions.FirstOrDefault(x => x.Id == 76)!.Score
        };
        yield return new DisorderRule()
        {
            Name = "A15",
            Value = questions.FirstOrDefault(x => x.Id == 6)!.Score
        };
    }

    private IEnumerable<DisorderRule> GetOppositionRules(IEnumerable<Question> questions)
    {
        yield return new DisorderRule()
        {
            Name = "A1",
            Value = questions.FirstOrDefault(x => x.Id == 14)!.Score,
            Predicate = (value) => value is 2 or 3
        };
        yield return new DisorderRule()
        {
            Name = "A2",
            Value = questions.FirstOrDefault(x => x.Id == 102)!.Score,
            Predicate = (value) => value is 2 or 3
        };
        yield return new DisorderRule()
        {
            Name = "A3",
            Value = questions.FirstOrDefault(x => x.Id == 94)!.Score,
            Predicate = (value) => value is 2 or 3
        };
        yield return new DisorderRule()
        {
            Name = "A4",
            Value = questions.FirstOrDefault(x => x.Id == 59)!.Score,
            Predicate = (value) => value is 2 or 3
        };
        yield return new DisorderRule()
        {
            Name = "A5",
            Value = questions.FirstOrDefault(x => x.Id == 21)!.Score,
            Predicate = (value) => value is 2 or 3
        };
        yield return new DisorderRule()
        {
            Name = "A6",
            Value = questions.FirstOrDefault(x => x.Id == 73)!.Score,
            Predicate = (value) => value is 2 or 3
        };
        yield return new DisorderRule()
        {
            Name = "A7",
            Value = questions.FirstOrDefault(x => x.Id == 48)!.Score
        };
        yield return new DisorderRule()
        {
            Name = "A8",
            Value = questions.FirstOrDefault(x => x.Id == 57)!.Score
        };
    }
}
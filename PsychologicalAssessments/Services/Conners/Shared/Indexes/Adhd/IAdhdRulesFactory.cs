using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd;

public interface IAdhdRulesFactory
{
    public Tuple<IEnumerable<AdhdRule>, IEnumerable<AdhdRule>> Create(IEnumerable<Question> questions);
}
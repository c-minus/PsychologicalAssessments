using PsychologicalAssessments.Orchestrator.Base;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Disorder;

namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.Disorder;

public interface IDisorderRulesFactory 
{
    public Tuple<IEnumerable<DisorderRule>, IEnumerable<DisorderRule>> Create(IEnumerable<Question> questions);
}
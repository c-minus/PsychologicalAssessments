using PsychologicalAssessments.Orchestrator;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.AdhdConners3;

public interface IAdhdConners3Calculator
{
    AdhdConners3Index Calculate(List<Question> questions);
}

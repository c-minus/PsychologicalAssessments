using PsychologicalAssessments.Orchestrator;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Result;

public interface IResultCalculator
{ 
    Result? Calculate(Subject subject);
}
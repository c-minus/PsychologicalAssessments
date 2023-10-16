using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Orchestrator.Tresult;

public interface ITresultCalculator
{ 
    Tresult? Calculate(Subject subject);
}
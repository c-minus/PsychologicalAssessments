namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Result;

public interface IResultCalculator
{ 
    Result? Calculate(Subject subject);
}
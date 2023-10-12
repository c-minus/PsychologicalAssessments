namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.PiAndNi;

public interface IPiAndNiIndexCalculator
{
    PiAndNiIndex Calculate(List<Question> questions);
}

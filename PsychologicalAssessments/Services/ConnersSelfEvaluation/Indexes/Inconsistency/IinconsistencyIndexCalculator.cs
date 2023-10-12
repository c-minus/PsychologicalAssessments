namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Inconsistency
{
    public interface IInconsistencyIndexCalculator
    {
        public InconsistencyIndex Calculate(List<Question> questions);
    }
}
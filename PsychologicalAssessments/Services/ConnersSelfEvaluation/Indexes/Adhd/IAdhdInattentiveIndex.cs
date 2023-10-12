namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Adhd
{
	public interface IAdhdInattentiveIndex
	{
		byte Calculate(List<Question> questions);
	}
}


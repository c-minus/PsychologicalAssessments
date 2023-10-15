using PsychologicalAssessments.Orchestrator;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Disorder
{
	public interface IBehaviorDisorderIndex
	{
		byte Calculate(List<Question> questions);
	}
}


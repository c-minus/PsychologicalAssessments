using PsychologicalAssessments.Orchestrator.ScoringType;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.ScoringType
{
	public class ConnersSelfScoringType : IScoringType
	{
		public string Get(byte id)
		{
			if (id is < 1 or > 97)
			{
				throw new Exception($"Invalid question id, found:{id} expecting between 1 and 97");
			}

			return id switch
			{
				1 => "3210",
				10 or 11 or 19 or 40 or 41 => "1100",
				12 or 93 => "1000",
				28 => "0011",
				37 or 48 or 54 or 75 => "0001",
				_ => "0123"
			};
		}

		/*
		   3210-> 1,
		   1100-> 10,11,19,40,41
		   1000-> 12,93
		   0011-> 28
		   0001-> 37,48,54,75
		*/
	}
}


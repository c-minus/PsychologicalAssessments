namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Disorder
{
	public class DisorderRule
	{
		public string? Name { get; set; }
		public byte Value { get; init; }
		public Func<byte, bool>? Predicate { get; init; }

		public bool IsMatch()
		{
			if (Predicate is null)
			{
				return Value is 1 or 2 or 3;
			}
			
			return Predicate(Value);
		}
	}
}


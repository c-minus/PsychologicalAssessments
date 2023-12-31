﻿namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Disorder
{
	public class DisorderRule
	{
		public string? Name { get; set; }
		public byte Value { get; set; }

		public Func<byte, bool>? Predicate { get; set; }

		public bool IsMatch()
		{
			return Predicate != null && Predicate(Value);
		}
	}
}


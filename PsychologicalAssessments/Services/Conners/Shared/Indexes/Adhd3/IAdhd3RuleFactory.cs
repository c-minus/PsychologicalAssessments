namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd3;

public interface IAdhd3RuleFactory
{
    public Tuple<IEnumerable<Adhd3Rule>, Func<byte,byte>> Create();
}
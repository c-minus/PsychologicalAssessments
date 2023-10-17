namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd;

public class AdhdRule
{
    public string? Name { get; set; }
    public byte Value1 { get; set; }
    public byte? Value2 { get; set; }

    public Func<byte, byte?, bool>? Predicate { get; set; }

    public bool IsMatch()
    {
        if (Predicate is null)
        {
            return Value1 is 2 or 3;
        }
        
        return Predicate!(Value1, Value2);
    }
}
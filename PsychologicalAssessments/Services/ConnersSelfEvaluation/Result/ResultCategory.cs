namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Result;

public class ResultCategory<T>
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public T? Value { get; set; }
}
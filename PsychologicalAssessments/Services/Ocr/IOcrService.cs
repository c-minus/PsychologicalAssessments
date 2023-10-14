namespace PsychologicalAssessments.Services.Ocr;

public interface IOcrService
{
    public void Process(MemoryStream ms);
}
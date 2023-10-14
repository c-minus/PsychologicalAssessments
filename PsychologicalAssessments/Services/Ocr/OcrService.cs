using IronOcr;

namespace PsychologicalAssessments.Services.Ocr;

public class OcrService : IOcrService
{
    public void Process(MemoryStream ms)
    {
        try
        {
            var ocr = new IronTesseract(); // nothing to configure
            using var input = new OcrInput(ms);

            var result = ocr.Read(input);
            Console.WriteLine(result.Text);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
namespace PsychologicalAssessments.Services.Clipboard
{
	public interface IClipboardService
	{
		Task CopyToClipboard(string text);
	}
}


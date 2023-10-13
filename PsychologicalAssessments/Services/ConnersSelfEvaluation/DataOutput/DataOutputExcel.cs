using MiniExcelLibs;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.DataOutput;

public class DataOutputExcel : IDataOutput
{
    public async Task<byte[]> GetByteArray(object [] template)
    {
        using var stream = new MemoryStream();
        
        await stream.SaveAsAsync(value: template, excelType: ExcelType.XLSX);

        return stream.ToArray();
    }
}
namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.DataOutput;

public interface IDataOutput
{
    public Task<byte []> GetByteArray(object [] template);
}
namespace PsychologicalAssessments.Orchestrator.DataOutput;

public interface IDataOutput
{
    public Task<byte []> GetByteArray(object [] template);
}
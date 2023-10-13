namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.DataOutput;

public interface IDataTemplate
{
    public object[] GetTemplate(Subject subject);
}
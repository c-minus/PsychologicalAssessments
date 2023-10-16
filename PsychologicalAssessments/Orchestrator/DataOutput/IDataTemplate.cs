using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Orchestrator.DataOutput;

public interface IDataTemplate
{
    public object[] GetTemplate(Subject subject);
}
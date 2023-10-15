using PsychologicalAssessments.Orchestrator;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.DataOutput;

public interface IDataTemplate
{
    public object[] GetTemplate(Subject subject);
}
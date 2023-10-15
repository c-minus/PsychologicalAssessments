using PsychologicalAssessments.Orchestrator;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Profiles;

public interface IProfileFactory
{
    public Profile Create(IdentifyAs? identifyAs, byte age);
}
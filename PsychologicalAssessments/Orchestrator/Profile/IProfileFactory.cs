using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Orchestrator.Profile;

public interface IProfileFactory
{
    public Profile Create(IdentifyAs? identifyAs, byte age);
}
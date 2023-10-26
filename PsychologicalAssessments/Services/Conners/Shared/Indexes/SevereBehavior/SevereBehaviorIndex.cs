namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.SevereBehavior;

public class SevereBehaviorIndex
{
    public byte ConfrontationalTheftScore { get; init; }
    public byte PoliceProblemsScoreOrForcedSexScore { get; init; }
    public byte AnimalCrueltyScore { get; init; }
    public byte UsingGunsScore { get; init; }
    public byte FireStarterScore { get; init; }
    public byte BreakingAndEnteringScore { get; init; }
    public byte ForcedSexScore { get; init; }

    public bool ConfrontationalTheft => ConfrontationalTheftScore >= 1;
    public bool PoliceProblemsScoreOrForcedSex => PoliceProblemsScoreOrForcedSexScore >= 1;
    public bool AnimalCruelty => AnimalCrueltyScore >= 1;
    public bool UsingGuns => UsingGunsScore >= 1;
    public bool FireStarter => FireStarterScore >= 1;
    public bool BreakingAndEntering => BreakingAndEnteringScore >= 1;

    public bool IsSevereBehavior => ConfrontationalTheft || 
                                    PoliceProblemsScoreOrForcedSex ||
                                    AnimalCruelty ||
                                    UsingGuns ||
                                    FireStarter ||
                                    BreakingAndEntering;
}

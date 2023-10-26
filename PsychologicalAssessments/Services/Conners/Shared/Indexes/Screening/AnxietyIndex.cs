namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.Screening;

public class AnxietyIndex
{
    public byte NervousOrAgitatedScore { get; init; }
    public byte IrritableScore { get; init; }
    public byte WorriedControlScore { get; init; }
    public byte WorriedScore { get; init; }

    public bool NervousOrAgitated => NervousOrAgitatedScore >= 1;
    public bool Irritable => IrritableScore >= 1;
    public bool WorriedControl => WorriedControlScore >= 1;
    public bool Worried => WorriedScore >= 1;
    
    public bool IsAnxiety => NervousOrAgitated || Irritable || WorriedControl || Worried;
}

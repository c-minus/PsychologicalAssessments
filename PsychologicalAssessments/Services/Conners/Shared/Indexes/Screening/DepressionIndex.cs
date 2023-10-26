namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.Screening;

public class DepressionIndex
{
    public byte UselessnessScore { get; init; }
    public byte LostOfInterestOrPleasureScore { get; init; }
    public byte SadnessOrIrritableScore { get; init; }
    public byte TiredOrLowEnergyScore { get; init; }

    public bool Uselessness => UselessnessScore >= 1;
    public bool LostOfInterestOrPleasure => LostOfInterestOrPleasureScore >= 1;
    public bool SadnessOrIrritable => SadnessOrIrritableScore >= 1;
    public bool TiredOrLowEnergy => TiredOrLowEnergyScore >= 1;
    
    public bool IsDepression => Uselessness || LostOfInterestOrPleasure || SadnessOrIrritable || TiredOrLowEnergy;
}

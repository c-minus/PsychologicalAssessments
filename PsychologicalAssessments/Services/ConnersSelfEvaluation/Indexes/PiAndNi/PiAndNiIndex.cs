namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.PiAndNi;

public class PiAndNiIndex
{
    public byte Pi { get; set; }
    public byte Ni { get; set; }
    public bool IsProbablyValidPi => Pi < 3;

    public bool IsProbablyValidNi => Ni < 3;
}

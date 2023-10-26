using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.Screening;

public class ScreeningCalculator : ICalculator
{
    private readonly IScreeningMapper _mapper;

    public ScreeningCalculator(IScreeningMapper mapper)
    {
        _mapper = mapper;
    }
    
    public object Calculate(object input)
    {
        var questions = (List<Question>)input;
        var mappings = _mapper.Get(questions);
        
        var anxietyIndex = new AnxietyIndex
        {
            IrritableScore = mappings.FirstOrDefault(m=>m.Key == "IrritableScore").Value,
            NervousOrAgitatedScore = mappings.FirstOrDefault(m=>m.Key == "NervousOrAgitatedScore").Value,
            WorriedControlScore =mappings.FirstOrDefault(m=>m.Key == "WorriedControlScore").Value,
            WorriedScore = mappings.FirstOrDefault(m=>m.Key == "WorriedScore").Value
        };

        var depressionIndex = new DepressionIndex
        {
            LostOfInterestOrPleasureScore = mappings.FirstOrDefault(m=>m.Key == "LostOfInterestOrPleasureScore").Value,
            SadnessOrIrritableScore = mappings.FirstOrDefault(m=>m.Key == "SadnessOrIrritableScore").Value,
            TiredOrLowEnergyScore = mappings.FirstOrDefault(m=>m.Key == "TiredOrLowEnergyScore").Value,
            UselessnessScore = mappings.FirstOrDefault(m=>m.Key == "UselessnessScore").Value
        };

        var screeningIndex = new ScreeningIndex
        {
            AnxietyIndex = anxietyIndex,
            DepressionIndex = depressionIndex
        };

        return screeningIndex;
    }
}
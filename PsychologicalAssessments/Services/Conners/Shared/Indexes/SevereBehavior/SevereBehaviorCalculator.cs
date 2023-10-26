using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.Conners.Shared.Indexes.SevereBehavior;

public class SevereBehaviorCalculator : ICalculator
{
    private readonly ISevereBehaviorMapper _mapper;

    public SevereBehaviorCalculator(ISevereBehaviorMapper mapper)
    {
        _mapper = mapper;
    }
    
    public object Calculate(object input)
    {
        var questions = (List<Question>)input;
        var mappings = _mapper.Get(questions);

        return new SevereBehaviorIndex
        {
            AnimalCrueltyScore = mappings.FirstOrDefault(m=>m.Key == "AnimalCrueltyScore").Value,
            BreakingAndEnteringScore = mappings.FirstOrDefault(m=>m.Key == "BreakingAndEnteringScore").Value,
            ConfrontationalTheftScore = mappings.FirstOrDefault(m=>m.Key == "ConfrontationalTheftScore").Value,
            FireStarterScore = mappings.FirstOrDefault(m=>m.Key == "FireStarterScore").Value,
            PoliceProblemsScoreOrForcedSexScore = mappings.FirstOrDefault(m=>m.Key == "PoliceProblemsOrForcedSexScore").Value,
            UsingGunsScore = mappings.FirstOrDefault(m=>m.Key == "UsingGunsScore").Value
        };
    }
}
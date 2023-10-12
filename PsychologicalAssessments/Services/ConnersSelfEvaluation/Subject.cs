using PsychologicalAssessments.Extensions;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Adhd;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.AdhdConners3;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Deterioration;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Disorder;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Inconsistency;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.PiAndNi;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Screening;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.SevereBehavior;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Profiles;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation;
public class Subject
{
    public Subject()
    {
        CreatedAt = DateTime.Now;
    }

    public string? Id { get; set; }
    public string? Name { get; set; }
    public State CurrentState { get; set; }
    public string? CurrentStateName => Enum.GetName(typeof(State), CurrentState);
    public byte Age { get; set; }
    public IdentifyAs? GenderInternal => Gender?.GetEnumValueByName<IdentifyAs>();
    public string? Gender { get; set; }
    public List<Question>? Questions { get; set; }
    public InconsistencyIndex? InconsistencyIndex { get; set; }
    public PiAndNiIndex? PiAndNiIndex { get; set; }
    public AdhdIndex? AdhdIndex { get; set; }
    public DateTime? CreatedAt { get; }
    public DisorderIndex? DisorderIndex { get; set; }
    public DeteriorationIndex? DeteriorationIndex { get; set; }
    public AdhdConners3Index? AdhdConners3Index { get; set; }
    public ScreeningIndex? ScreeningIndex { get; set; }
    public SevereBehaviorIndex? SevereBehaviorIndex { get; set; }
    public Profile? Profile { get; set; }
    public Result.Result? Result { get; set; }
}
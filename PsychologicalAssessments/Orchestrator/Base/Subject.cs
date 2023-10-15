using PsychologicalAssessments.Extensions;
using PsychologicalAssessments.Orchestrator.Rules;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Adhd;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.AdhdConners3;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Deterioration;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Disorder;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Inconsistency;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.PiAndNi;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Screening;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.SevereBehavior;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Profiles;

namespace PsychologicalAssessments.Orchestrator.Base;
public class Subject
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public KeyValuePair<byte,string> CurrentState { get; set; }
    public byte Age { get; set; }
    public IdentifyAs? GenderInternal => Gender?.GetEnumValueByName<IdentifyAs>();
    public string? Gender { get; set; }
    public List<Question>? Questions { get; set; }
    
    public List<Rule>? Rules { get; set; }
    
    public DateTime? CreatedAt { get; } = DateTime.Now;
    public DisorderIndex? DisorderIndex { get; set; }
    public DeteriorationIndex? DeteriorationIndex { get; set; }
    public AdhdConners3Index? AdhdConners3Index { get; set; }
    public ScreeningIndex? ScreeningIndex { get; set; }
    public SevereBehaviorIndex? SevereBehaviorIndex { get; set; }
    public Profile? Profile { get; set; }
    public Services.ConnersSelfEvaluation.Result.Result? Result { get; set; }
}
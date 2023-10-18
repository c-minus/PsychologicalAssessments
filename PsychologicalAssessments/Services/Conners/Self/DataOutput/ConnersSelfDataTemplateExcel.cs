using PsychologicalAssessments.Orchestrator.Base;
using PsychologicalAssessments.Orchestrator.DataOutput;
using PsychologicalAssessments.Services.Conners.Self.Indexes.Disorder;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Adhd3;
using PsychologicalAssessments.Services.Conners.Shared.Indexes.Inconsistency;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Disorder;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Screening;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.SevereBehavior;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.DataOutput;

public class ConnersSelfDataTemplateExcel : IDataTemplate
{
    public object[] GetTemplate(Subject subject)
    {
        var inconsistencyIndex = (InconsistencyIndex)subject.Rules?
            .FirstOrDefault(r => r.Name == "InconsistencyIndex")!.Output!;
        var adhdIndex = (AdhdIndex)subject.Rules?
            .FirstOrDefault(r => r.Name == "AdhdIndex")!.Output!;
        var disorderIndex = (DisorderIndex)subject.Rules?
            .FirstOrDefault(r => r.Name == "DisorderIndex")!.Output!;
        var adhdConners3Index = (Adhd3Index)subject.Rules?
            .FirstOrDefault(r => r.Name == "AdhdConners3Index")!.Output!;
        var screeningIndex = (ScreeningIndex)subject.Rules?
            .FirstOrDefault(r => r.Name == "ScreeningIndex")!.Output!;
        var severeBehaviorIndex = (SevereBehaviorIndex)subject.Rules?
            .FirstOrDefault(r => r.Name == "SevereBehaviorIndex")!.Output!;
        
        return new object[]
        {
            new
            {
                Item = "Indicele de inconsistență",
                Value = (bool)inconsistencyIndex.IsProbablyInvalid! ? 0 : 1
            },
            new
            {
                Item = "Neatenție",
                Value = (int)subject?.TResult?.Items?.FirstOrDefault(i => i.Id is "IN")!.Value!
            },
            new
            {
                Item = "Hiperactivitate/Impulsivitate",
                Value = (int)subject?.TResult?.Items?.FirstOrDefault(i => i.Id is "HY")!.Value!
            },
            new
            {
                Item = "Probleme de învățare",
                Value = (int)subject?.TResult?.Items?.FirstOrDefault(i => i.Id is "LP")!.Value!
            },
            new
            {
                Item = "Agresivitate",
                Value = (int)subject?.TResult?.Items?.FirstOrDefault(i => i.Id is "AG")!.Value!
            },
            new
            {
                Item = "Relațiile cu familia",
                Value = (int)subject?.TResult?.Items?.FirstOrDefault(i => i.Id is "FR")!.Value!
            },
            new
            {
                Item = "Scor T ADHD Neatent",
                Value = (int)subject?.TResult?.Items?.FirstOrDefault(i => i.Id is "AN")!.Value!
            },
            new
            {
                Item = "Scor simptom ADHD Neatent",
                Value = (bool)adhdIndex.IsProbablyInattentive! ? 1 : 0
            },
            new
            {
                Item = "Scor T ADHD Hiperactiv-Impulsiv",
                Value = (int)subject?.TResult?.Items?.FirstOrDefault(i => i.Id is "AH")!.Value!
            },
            new
            {
                Item = "Scor simptom Hiperactiv-Impulsiv",
                Value = (bool)adhdIndex?.IsProbablyHyperActive! ? 1 : 0
            },
            new
            {
                Item = "Scor simptom ADHD Combinat",
                Value = (bool)adhdIndex?.IsProbablyBoth! ? 1 : 0
            },
            new
            {
                Item = "Scor T Tulburare de Comportament",
                Value = (int)subject?.TResult?.Items?.FirstOrDefault(i => i.Id is "CD")!.Value!
            },
            new
            {
                Item = "Scor simptom Tulburare de Comportament",
                Value = (bool)disorderIndex?.IsProbablyBehavior! ? 1 : 0
            },
            new
            {
                Item = "Scor T Tulburare de opoziție",
                Value = (int)subject?.TResult?.Items?.FirstOrDefault(i => i.Id is "OD")!.Value!
            },
            new
            {
                Item = "Scor simptom Tulburare de opoziție",
                Value = (bool)disorderIndex?.IsProbablyOpposition! ? 1 : 0
            },
            new
            {
                Item = "Indicele ADHD Conners 3 scor probabilitate",
                Value = (int)adhdConners3Index?.Probability!
            },
            new
            {
                Item = "Anxietate",
                Value = (bool)screeningIndex?.AnxietyIndex?.IsAnxiety ? 1 : 0
            },
            new
            {
                Item = "Depresie",
                Value = (bool)screeningIndex?.DepressionIndex?.IsDepression ? 1 : 0
            },
            new
            {
                Item = "Comportament sever",
                Value = (bool)severeBehaviorIndex?.IsSevereBehavior ? 1 : 0
            },
        };
    }
}
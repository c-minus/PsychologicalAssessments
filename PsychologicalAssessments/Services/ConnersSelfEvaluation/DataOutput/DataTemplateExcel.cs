using PsychologicalAssessments.Orchestrator;
using PsychologicalAssessments.Orchestrator.Base;

namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.DataOutput;

public class DataTemplateExcel : IDataTemplate
{
    public object[] GetTemplate(Subject subject)
    {
        return new object[]
        {
            // new
            // {
            //     Item = "Indicele de inconsistență",
            //     Value = (bool)subject.InconsistencyIndex!.IsProbablyInvalid! ? 0 : 1
            // },
            new
            {
                Item = "Neatenție",
                Value = (int)subject?.Result?.ResultT?.FirstOrDefault(r => r.Id == "IN")!.Value!
            },
            new
            {
                Item = "Hiperactivitate/Impulsivitate",
                Value = (int)subject.Result.ResultT.FirstOrDefault(r => r.Id == "HY")!.Value
            },
            new
            {
                Item = "Probleme de învățare",
                Value = (int)subject.Result.ResultT.FirstOrDefault(r => r.Id == "LP")!.Value
            },
            new
            {
                Item = "Agresivitate",
                Value = (int)subject.Result.ResultT.FirstOrDefault(r => r.Id == "AG")!.Value
            },
            new
            {
                Item = "Relațiile cu familia",
                Value = (int)subject.Result.ResultT.FirstOrDefault(r => r.Id == "FR")!.Value
            },
            new
            {
                Item = "Scor T ADHD Neatent",
                Value = (int)subject.Result.ResultT.FirstOrDefault(r => r.Id == "AN")!.Value
            },
            // new
            // {
            //     Item = "Scor simptom ADHD Neatent",
            //     Value = (bool)subject?.AdhdIndex?.IsProbablyInattentive! ? 1 : 0
            // },
            // new
            // {
            //     Item = "Scor T ADHD Hiperactiv-Impulsiv",
            //     Value = (int)subject.Result.ResultT.FirstOrDefault(r => r.Id == "AH")!.Value
            // },
            // new
            // {
            //     Item = "Scor simptom Hiperactiv-Impulsiv",
            //     Value = (bool)subject?.AdhdIndex?.IsProbablyHyperActive! ? 1 : 0
            // },
            // new
            // {
            //     Item = "Scor simptom ADHD Combinat",
            //     Value = (bool)subject?.AdhdIndex?.IsProbablyBoth! ? 1 : 0
            // },
            new
            {
                Item = "Scor T Tulburare de Comportament",
                Value = (int)subject.Result.ResultT.FirstOrDefault(r => r.Id == "CD")!.Value
            },
            new
            {
                Item = "Scor simptom Tulburare de Comportament",
                Value = (bool)subject?.DisorderIndex?.IsProbablyBehavior! ? 1 : 0
            },
            new
            {
                Item = "Scor T Tulburare de opoziție",
                Value = (int)subject.Result.ResultT.FirstOrDefault(r => r.Id == "OD")!.Value
            },
            new
            {
                Item = "Scor simptom Tulburare de opoziție",
                Value = (bool)subject?.DisorderIndex?.IsProbablyOpposition! ? 1 : 0
            },
            new
            {
                Item = "Activități școlare/clasa",
                Value = (int)subject?.DeteriorationIndex?.School!
            },
            new
            {
                Item = "Prietenie/Relație",
                Value = (int)subject?.DeteriorationIndex?.Friends!
            },
            new
            {
                Item = "Viața acasă",
                Value = (int)subject?.DeteriorationIndex?.Home!
            },
            new
            {
                Item = "Indicele ADHD Conners 3 scor probabilitate",
                Value = (int)subject?.AdhdConners3Index?.Probability!
            },
            new
            {
                Item = "Anxietate",
                Value = (bool)subject?.ScreeningIndex?.AnxietyIndex?.IsAnxiety? 1 : 0
            },
            new
            {
                Item = "Depresie",
                Value = (bool)subject?.ScreeningIndex?.DepressionIndex?.IsDepression? 1 : 0
            },
            new
            {
                Item = "Comportament sever",
                Value = (bool)subject?.SevereBehaviorIndex?.IsSevereBehavior? 1 : 0
            },
        };
    }
}
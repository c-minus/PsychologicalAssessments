namespace PsychologicalAssessments.Services.ConnersSelfEvaluation.DataOutput;

public class DataTemplateExcel : IDataTemplate
{
    public object[] GetTemplate(Subject subject)
    {
        var value = new[]
        {
            new
            {
                Item = "Indicele de inconsistenta", Value = (bool)subject.InconsistencyIndex!.IsProbablyInvalid! ? "Probabil Invalid" : " Probabil Valid",
                // Item="Neatentie", Value = subject.Result.ResultT.Where(r=>r.)
            },
        };
        throw new NotImplementedException();
    }
}
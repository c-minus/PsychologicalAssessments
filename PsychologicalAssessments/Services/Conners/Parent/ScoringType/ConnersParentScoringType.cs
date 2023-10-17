using PsychologicalAssessments.Orchestrator.ScoringType;

namespace PsychologicalAssessments.Services.ConnersParent.ScoringType
{
    public class ConnersParentScoringType : IScoringType
    {
        public string Get(byte id)
        {
            if (id is < 1 or > 108)
            {
                throw new Exception($"Invalid question id, found:{id} expecting between 1 and 108");
            }

            return id switch
            {
                9 or 64 or 72 => "3210",
                1 or 8 => "1100",
                31 or 38 => "1000",
                18 or 26 or 32 or 42 => "0011",
                33 or 74 or 80 or 105 => "0001",
                _ => "0123"
            };
        }

        /*
           3210-> 9,64,72
           1100-> 1,8
           1000-> 31,38
           0011-> 18,26,32,42
           0001-> 33,74,80,105
        */
    }
}
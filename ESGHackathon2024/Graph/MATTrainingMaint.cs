using PX.Data;
using PX.Data.BQL.Fluent;

namespace ESGHackathon2024
{
    public class MATTrainingMaint : PXGraph<MATTrainingMaint, MATTraining>
    {
        public SelectFrom<MATTraining>.View Document;
    }
}
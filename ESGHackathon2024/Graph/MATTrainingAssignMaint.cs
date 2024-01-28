using PX.Data;
using PX.Data.BQL.Fluent;

namespace ESGHackathon2024
{
    public class MATTrainingAssignMaint : PXGraph<MATTrainingAssignMaint, MATTrainingAssign>
    {
        public SelectFrom<MATTrainingAssign>.View Assignment;
    }
}
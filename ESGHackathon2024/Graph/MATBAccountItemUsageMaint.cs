using PX.Data;
using PX.Data.BQL.Fluent;

namespace ESGHackathon2024
{
    public class MATBAccountItemUsageMaint : PXGraph<MATBAccountItemUsageMaint, MATBAccountItemUsage>
    {
        public SelectFrom<MATBAccountItemUsage>.View BAccountItemUsages;
    }
}
using PX.Data;
using PX.Data.BQL.Fluent;

namespace Hackathon2024
{
    public class MATPosTypeMaint : PXGraph<MATPosTypeMaint, MATPosType>
    {
        public SelectFrom<MATPosType>.View PosTypes;
    }
}
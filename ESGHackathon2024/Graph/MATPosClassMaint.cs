using PX.Data;
using PX.Data.BQL.Fluent;

namespace Hackathon2024
{
    public class MATPosClassMaint : PXGraph<MATPosClassMaint, MATPosClass>
    {
        public SelectFrom<MATPosClass>.View PosClasses;
    }
}
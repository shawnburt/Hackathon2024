using PX.Data;
using PX.Data.BQL.Fluent;

namespace ESGHackathon2024
{
    public class MATIncidentClassMaint : PXGraph<MATIncidentClassMaint>
  {
        public SelectFrom<MATIncidentClass>.View Records;
		public PXSavePerRow<MATIncidentClass> Save;
		public PXCancel<MATIncidentClass> Cancel;
	}
}

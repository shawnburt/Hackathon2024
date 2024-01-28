using PX.Data;
using PX.Data.BQL.Fluent;

namespace ESGHackathon2024
{
    public class MATIncidentTypeMaint : PXGraph<MATIncidentTypeMaint>
	{
		public SelectFrom<MATIncidentType>.View Records;
		public PXSavePerRow<MATIncidentType> Save;
		public PXCancel<MATIncidentType> Cancel;		
	}
}

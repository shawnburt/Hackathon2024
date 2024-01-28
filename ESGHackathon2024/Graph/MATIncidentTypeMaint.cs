using ESG;
using PX.Data;
using PX.Objects.CS;
using PX.Objects.GL;

namespace ESGHackathon2024
{
	public class MATIncidentTypeMaint : PXGraph<MATIncidentTypeMaint>
	{
		public PXSelect<MATIncidentType> Records;
		public PXSavePerRow<MATIncidentType> Save;
		public PXCancel<MATIncidentType> Cancel;		
	}
}

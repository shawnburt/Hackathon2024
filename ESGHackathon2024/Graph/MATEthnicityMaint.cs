using PX.Data;
using PX.Objects.CS;
using PX.Objects.GL;

namespace ESGHackathon2024
{
	public class MATEthnicityMaint : PXGraph<MATEthnicityMaint>
	{
		public PXSelect<MATEthnicity> Records;
		public PXSavePerRow<MATEthnicity> Save;
		public PXCancel<MATEthnicity> Cancel;		
	}
}

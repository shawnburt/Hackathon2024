using PX.Data;
using PX.Data.BQL.Fluent;

namespace ESGHackathon2024
{
	public class MATEthnicityMaint : PXGraph<MATEthnicityMaint>
	{
		public SelectFrom<MATEthnicity>.View Records;
		public PXSavePerRow<MATEthnicity> Save;
		public PXCancel<MATEthnicity> Cancel;
	}
}
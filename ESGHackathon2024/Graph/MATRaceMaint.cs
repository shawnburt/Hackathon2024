using PX.Data;
using PX.Data.BQL.Fluent;

namespace ESGHackathon2024
{
	public class MATRaceMaint : PXGraph<MATRaceMaint>
	{
		public SelectFrom<MATRace>.View Records;
		public PXSavePerRow<MATRace> Save;
		public PXCancel<MATRace> Cancel;
	}
}
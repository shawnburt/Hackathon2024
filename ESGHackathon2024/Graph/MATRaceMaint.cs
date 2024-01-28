using PX.Data;
using PX.Objects.CS;
using PX.Objects.GL;

namespace ESGHackathon2024
{
	public class MATRaceMaint : PXGraph<MATRaceMaint>
	{
		public PXSelect<MATRace> Records;
		public PXSavePerRow<MATRace> Save;
		public PXCancel<MATRace> Cancel;		
	}
}

using System;
using PX.Data;

namespace ESGHackathon2024
{
  public class MATIncidentClassMaint : PXGraph<MATIncidentClassMaint>
  {
        public PXSelect<MATIncidentClass> Records;
		public PXSavePerRow<MATIncidentClass> Save;
		public PXCancel<MATIncidentClass> Cancel;
	}
}

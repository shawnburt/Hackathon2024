using System;
using PX.Data;

namespace ESGHackathon2024
{
	public class MATTrainingTypeMaint : PXGraph<MATTrainingTypeMaint>
	{
		public PXSelect<MATTrainingType> Document;
		public PXSavePerRow<MATTrainingType> Save;
		public PXCancel<MATTrainingType> Cancel;
	}
}

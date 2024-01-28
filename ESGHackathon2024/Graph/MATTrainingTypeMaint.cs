using PX.Data;
using PX.Data.BQL.Fluent;

namespace ESGHackathon2024
{
    public class MATTrainingTypeMaint : PXGraph<MATTrainingTypeMaint>
	{
		public SelectFrom<MATTrainingType>.View Document;
		public PXSavePerRow<MATTrainingType> Save;
		public PXCancel<MATTrainingType> Cancel;
	}
}

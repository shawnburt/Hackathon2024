using System.Collections;
using PX.Data;
using PX.Data.BQL.Fluent;

namespace ESGHackathon2024
{
	public class MATIncidentEntry : PXGraph<MATIncidentEntry, MATIncident>
	{
		public SelectFrom<MATIncident>.View Document;

		public PXAction<MATIncident> inProgress;
		[PXButton(CommitChanges = true), PXUIField(DisplayName = MATMessages.InProgress, Visible = true, MapEnableRights = PXCacheRights.Select)]
		protected virtual IEnumerable InProgress(PXAdapter adapter)
		{
			return adapter.Get();
		}

		public PXAction<MATIncident> close;
		[PXButton(CommitChanges = true), PXUIField(DisplayName = MATMessages.Close, Visible = true, MapEnableRights = PXCacheRights.Select)]
		protected virtual IEnumerable Close(PXAdapter adapter)
		{
			return adapter.Get();
		}

		public PXAction<MATIncident> decline;
		[PXButton(CommitChanges = true), PXUIField(DisplayName = MATMessages.Decline, Visible = true, MapEnableRights = PXCacheRights.Select)]
		protected virtual IEnumerable Decline(PXAdapter adapter)
		{
			return adapter.Get();
		}
	}
}
using System.Collections;
using PX.Data;

namespace ESGHackathon2024
{
  public class MATIncidentEntry : PXGraph<MATIncidentEntry, MATIncident>
  {
        public PXSelect<MATIncident> Document;

		public PXAction<MATIncident> inProgress;
		[PXButton(CommitChanges = true), PXUIField(DisplayName = "In Progress", Visible = true, MapEnableRights = PXCacheRights.Select)]
		protected virtual IEnumerable InProgress(PXAdapter adapter)
		{

			return adapter.Get();
		}

		public PXAction<MATIncident> close;
		[PXButton(CommitChanges = true), PXUIField(DisplayName = "Close", Visible = true, MapEnableRights = PXCacheRights.Select)]
		protected virtual IEnumerable Close(PXAdapter adapter)
		{

			return adapter.Get();
		}

		public PXAction<MATIncident> decline;
		[PXButton(CommitChanges = true), PXUIField(DisplayName = "Decline", Visible = true, MapEnableRights = PXCacheRights.Select)]
		protected virtual IEnumerable Decline(PXAdapter adapter)
		{

			return adapter.Get();
		}

		#region Event Handlers
		#endregion
	}
}

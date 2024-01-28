using System;
using System.Collections.Generic;
using System.Linq;
using ESG;
using PX.Data;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Objects.CS;
using PX.Objects.IN;
using PX.Objects.SO;

namespace ESGHackathon2024
{
	[Serializable]
	[PXCacheName("Incident Class")]
	public class MATIncidentClass : IBqlTable
	{
		#region Keys
		public class PK : PrimaryKeyOf<MATIncidentClass>.By<incidentClassID>
		{
			public static MATIncidentClass Find(PXGraph graph, string incidentClassID, PKFindOptions options = PKFindOptions.None) => FindBy(graph, incidentClassID, options);
		}
		#endregion

		#region IncidentClassID
		public abstract class incidentClassID : PX.Data.BQL.BqlString.Field<incidentClassID>
		{
		}

		[PXDBString(20, IsUnicode = true, IsKey = true, InputMask = ">aaaaaaaaaa")]
		[PXUIField(DisplayName = "Incident Class", Visibility = PXUIVisibility.SelectorVisible)]
		[PXDefault]
		public virtual String IncidentClassID
		{
			get;
			set;
		}
		#endregion

		#region Description
		public abstract class description : PX.Data.BQL.BqlString.Field<description> { }

		[PXDBString(60, IsUnicode = true)]
		[PXUIField(DisplayName = "Description", Visibility = PXUIVisibility.SelectorVisible)]
		public virtual String Description
		{
			get;
			set;
		}
		#endregion

		#region IncidentTypeID
		public abstract class incidentTypeID : PX.Data.BQL.BqlString.Field<incidentTypeID> { }

		[PXDBString(2, IsUnicode = true)]
		[PXUIField(DisplayName = "Incident Type", Visibility = PXUIVisibility.Visible, Visible = true, Enabled = true)]
		[PXSelector(typeof(MATIncidentType.incidentTypeID), DescriptionField = typeof(MATIncidentType.description))]
		[PXDefault]
		public string IncidentTypeID
		{
			get;
			set;
		}
		#endregion
	}
}

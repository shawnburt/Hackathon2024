using System;
using PX.Data;
using PX.Data.ReferentialIntegrity.Attributes;

namespace ESGHackathon2024
{
    [Serializable]
	[PXCacheName(MATMessages.IncidentClass)]
	public class MATIncidentClass : IBqlTable
	{
		#region Keys
		public class PK : PrimaryKeyOf<MATIncidentClass>.By<incidentClassID>
		{
			public static MATIncidentClass Find(PXGraph graph, string incidentClassID, PKFindOptions options = PKFindOptions.None) => FindBy(graph, incidentClassID, options);
		}
        public static class FK
        {
            public class IncidentType : MATIncidentType.PK.ForeignKeyOf<MATIncidentClass>.By<incidentTypeID> { }
        }
        #endregion


        #region IncidentClassID
        public abstract class incidentClassID : PX.Data.BQL.BqlString.Field<incidentClassID>
		{
		}

		[PXDBString(20, IsUnicode = true, IsKey = true, InputMask = ">aaaaaaaaaa")]
		[PXUIField(DisplayName = MATMessages.IncidentClass, Visibility = PXUIVisibility.SelectorVisible)]
		[PXDefault]
        [PXForeignReference(typeof(FK.IncidentType))]
        public virtual string IncidentClassID { get; set; }
		#endregion

		#region Description
		public abstract class description : PX.Data.BQL.BqlString.Field<description> { }

		[PXDBString(60, IsUnicode = true)]
		[PXUIField(DisplayName = MATMessages.Description, Visibility = PXUIVisibility.SelectorVisible)]
		public virtual string Description { get; set; }
		#endregion

		#region IncidentTypeID
		public abstract class incidentTypeID : PX.Data.BQL.BqlString.Field<incidentTypeID> { }

		[PXDBString(2, IsUnicode = true)]
		[PXUIField(DisplayName = MATMessages.IncidentType, Visibility = PXUIVisibility.Visible, Visible = true, Enabled = true)]
		[PXSelector(typeof(MATIncidentType.incidentTypeID), DescriptionField = typeof(MATIncidentType.description))]
		[PXDefault]
		public string IncidentTypeID { get; set; }
		#endregion
	}
}

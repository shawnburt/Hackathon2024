using System;
using PX.Data;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Objects.CS;

namespace ESGHackathon2024
{
    [Serializable]
	[PXCacheName(MATMessages.IncidentType)]
	public class MATIncidentType : IBqlTable
	{
		#region Keys
		public class PK : PrimaryKeyOf<MATIncidentType>.By<incidentTypeID>
		{
			public static MATIncidentType Find(PXGraph graph, string incidentTypeID, PKFindOptions options = PKFindOptions.None) => FindBy(graph, incidentTypeID, options);
		}
		#endregion


		#region IncidentTypeID
		public abstract class incidentTypeID : PX.Data.BQL.BqlString.Field<incidentTypeID>
		{
		}

		[PXDBString(2, IsKey = true, IsFixed = true, InputMask = ">aa")]
		[PXUIField(DisplayName = MATMessages.IncidentType, Visibility = PXUIVisibility.SelectorVisible)]
		[PXDefault]
		public virtual string IncidentTypeID { get; set; }
		#endregion

		#region Description
		public abstract class description : PX.Data.BQL.BqlString.Field<description> { }

		[PXDBString(60, IsUnicode = true)]
		[PXUIField(DisplayName = MATMessages.Description, Visibility = PXUIVisibility.SelectorVisible)]
		public virtual string Description { get; set; }
		#endregion

		#region NumberingID
		public abstract class numberingID : PX.Data.BQL.BqlString.Field<numberingID> { }
		
		[PXDBString(10, IsUnicode = true)]
		[PXDefault]
		[PXSelector(typeof(Search<Numbering.numberingID>))]
		[PXUIField(DisplayName = MATMessages.NumberingSequence)]
		public virtual string NumberingID { get; set; }
		#endregion
	}
}

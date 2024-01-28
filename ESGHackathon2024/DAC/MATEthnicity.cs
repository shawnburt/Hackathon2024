using PX.Data;
using PX.Data.ReferentialIntegrity.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESGHackathon2024
{
	[Serializable]
	[PXCacheName("Ethnicity", PXDacType.Catalogue)]
	[PXPrimaryGraph(typeof(MATEthnicityMaint))]
	public partial class MATEthnicity : IBqlTable
	{
		#region Keys
		public class PK : PrimaryKeyOf<MATEthnicity>.By<ethnicityID>
		{
			public static MATEthnicity Find(PXGraph graph, string ethnicityID) => FindBy(graph, ethnicityID);
		}
		#endregion
		#region EthnicityID
		public abstract class ethnicityID : PX.Data.BQL.BqlString.Field<ethnicityID> { }

		[PXDBString(20, IsUnicode = true, IsKey = true, InputMask = ">aaaaaaaaaa")]
		[PXDefault]
		[PXUIField(DisplayName = "Ethnicity", Visibility = PXUIVisibility.SelectorVisible)]
		public virtual String EthnicityID
		{
			get;
			set;
		}
		#endregion

		#region RaceID
		public abstract class raceID : PX.Data.BQL.BqlString.Field<raceID> { }

		[PXDBString(20, IsUnicode = true)]
		[PXUIField(DisplayName = "Race", Visibility = PXUIVisibility.Visible, Visible = true, Enabled = true)]
		[PXSelector(typeof(MATRace.raceID), DescriptionField = typeof(MATRace.description))]
		public string RaceID
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
	}
}

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
	[PXCacheName("Race", PXDacType.Catalogue)]
	[PXPrimaryGraph(typeof(MATRaceMaint))]
	public partial class MATRace : IBqlTable
	{
		#region Keys
		public class PK : PrimaryKeyOf<MATRace>.By<raceID>
		{
			public static MATRace Find(PXGraph graph, string raceID) => FindBy(graph, raceID);
		}
		#endregion
		#region RaceID
		public abstract class raceID : PX.Data.BQL.BqlString.Field<raceID> { }

		[PXDBString(20, IsUnicode = true, IsKey = true, InputMask = ">aaaaaaaaaa")]
		[PXDefault]
		[PXUIField(DisplayName = "Race", Visibility = PXUIVisibility.SelectorVisible)]
		public virtual String RaceID
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

using System;
using System.Collections.Generic;
using System.Linq;
using PX.Data;
using PX.Objects.CR;

namespace ESGHackathon2024
{
	public class ContactESG : PXCacheExtension<Contact>
	{
		public static bool IsActive() => true;

		#region EthnicityID
		public abstract class ethnicityID : PX.Data.BQL.BqlString.Field<ethnicityID> { }

		[PXDBString(20, IsUnicode = true)]
		[PXUIField(DisplayName = "Ethnicity", Visibility = PXUIVisibility.Visible, Visible = true, Enabled = true)]
		[PXSelector(typeof(MATEthnicity.ethnicityID), new Type[] {
				typeof(MATEthnicity.ethnicityID),
				typeof(MATEthnicity.raceID),
				typeof(MATEthnicity.description)
			}, DescriptionField = typeof(MATEthnicity.description))]
		public string EthnicityID
		{
			get;
			set;
		}
		#endregion
	}
}

using System;
using PX.Data;
using PX.Data.BQL;
using PX.Objects.CR;

namespace ESGHackathon2024
{
	// Acuminator disable once PX1016 ExtensionDoesNotDeclareIsActiveMethod extension should be constantly active
	public sealed class ContactExt : PXCacheExtension<Contact>
	{
		#region Keys
		public static class FK
		{
			public class Ethnicity : MATEthnicity.PK.ForeignKeyOf<Contact>.By<ethnicityID> { }
		}
		#endregion


		#region EthnicityID
		[PXDBString(20, IsUnicode = true, InputMask = "")]
		[PXUIField(DisplayName = "Ethnicity", Visibility = PXUIVisibility.Visible, Visible = true, Enabled = true)]
		[PXSelector(typeof(MATEthnicity.ethnicityID), new Type[] {
				typeof(MATEthnicity.ethnicityID),
				typeof(MATEthnicity.raceID),
				typeof(MATEthnicity.description)
			}, DescriptionField = typeof(MATEthnicity.description))]
		public string EthnicityID { get; set; }
		public abstract class ethnicityID : BqlString.Field<ethnicityID> { }
		#endregion
	}
}
using System;
using PX.Data;
using PX.Data.BQL;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Objects.CR;
using PX.Objects.EP;
using CR = PX.Objects.CR;

namespace ESGHackathon2024
{
	[Serializable]
	[PXCacheName(MATMessages.TrainingAssign)]
	[PXPrimaryGraph(typeof(MATTrainingAssignMaint))]
	public class MATTrainingAssign : IBqlTable
	{
		#region Keys
		public class PK : PrimaryKeyOf<MATTrainingAssign>.By<bAccountID, trainingID>
		{
			public static MATTrainingAssign Find(PXGraph graph, int? bAccountID, int? trainingID, PKFindOptions options = PKFindOptions.None) => FindBy(graph, bAccountID, trainingID, options);
		}
		public static class FK
		{
			public class BAccount : CR.BAccount.PK.ForeignKeyOf<EPPosition>.By<bAccountID> { }
			public class Training : MATTraining.PK.ForeignKeyOf<EPPosition>.By<trainingID> { }
		}
		#endregion


		#region BAccountID
		[PXDBInt(IsKey = true)]
		[PXUIField(DisplayName = MATMessages.BusinessAccount)]
		[PXSelector(typeof(Search<BAccount.bAccountID>), SubstituteKey = typeof(BAccount.acctCD), DescriptionField = typeof(BAccount.acctName))]
		[PXParent(typeof(Select<BAccount, Where<BAccount.bAccountID, Equal<Current<BAccount.bAccountID>>>>))]
		[PXForeignReference(typeof(FK.BAccount))]
		public virtual int? BAccountID { get; set; }
		public abstract class bAccountID : BqlInt.Field<bAccountID> { }
		#endregion

		#region TrainingID
		[PXDBInt(IsKey = true)]
		[PXUIField(DisplayName = MATMessages.Training)]
		[PXSelector(typeof(Search<MATTraining.trainingID>), SubstituteKey = typeof(MATTraining.trainingCD), DescriptionField = typeof(MATTraining.descr))]
		[PXForeignReference(typeof(FK.Training))]
		public virtual int? TrainingID { get; set; }
		public abstract class trainingID : BqlInt.Field<trainingID> { }
		#endregion

		#region CompletionDate
		[PXDBDate]
		[PXUIField(DisplayName = MATMessages.CompletionDate)]
		public virtual DateTime? CompletionDate { get; set; }
		public abstract class completionDate : BqlDateTime.Field<completionDate> { }
		#endregion

		#region Tstamp
		[PXDBTimestamp()]
		public virtual byte[] Tstamp { get; set; }
		public abstract class tstamp : BqlByteArray.Field<tstamp> { }
		#endregion

		#region CreatedByID
		[PXDBCreatedByID()]
		public virtual Guid? CreatedByID { get; set; }
		public abstract class createdByID : BqlGuid.Field<createdByID> { }
		#endregion

		#region CreatedByScreenID
		[PXDBCreatedByScreenID()]
		public virtual string CreatedByScreenID { get; set; }
		public abstract class createdByScreenID : BqlString.Field<createdByScreenID> { }
		#endregion

		#region CreatedDateTime
		[PXDBCreatedDateTime()]
		public virtual DateTime? CreatedDateTime { get; set; }
		public abstract class createdDateTime : BqlDateTime.Field<createdDateTime> { }
		#endregion

		#region LastModifiedByID
		[PXDBLastModifiedByID()]
		public virtual Guid? LastModifiedByID { get; set; }
		public abstract class lastModifiedByID : BqlGuid.Field<lastModifiedByID> { }
		#endregion

		#region LastModifiedByScreenID
		[PXDBLastModifiedByScreenID()]
		public virtual string LastModifiedByScreenID { get; set; }
		public abstract class lastModifiedByScreenID : BqlString.Field<lastModifiedByScreenID> { }
		#endregion

		#region LastModifiedDateTime
		[PXDBLastModifiedDateTime()]
		public virtual DateTime? LastModifiedDateTime { get; set; }
		public abstract class lastModifiedDateTime : BqlDateTime.Field<lastModifiedDateTime> { }
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using ESG;
using PX.Data;
using PX.Data.BQL;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Objects.CS;
using PX.Objects.EP;
using PX.Objects.FA;

namespace ESGHackathon2024
{
	public class MATIncident : IBqlTable
	{
		#region Keys
		public class PK : PrimaryKeyOf<MATIncident>.By<incidentType, incidentNbr>
		{
			public static MATIncident Find(PXGraph graph, string incidentType, string incidentNbr, PKFindOptions options = PKFindOptions.None) => FindBy(graph, incidentType, incidentNbr, options);
		}
		#endregion

		#region IncidentType
		/// <inheritdoc cref="IncidentType"/>
		public abstract class incidentType : PX.Data.BQL.BqlString.Field<incidentType> { }

		[PXDBString(2, IsKey = true, IsFixed = true, InputMask = ">aa")]
		[PXDefault(MATIncidentTypeConstants.People)]
		[PXSelector(typeof(MATIncidentType.incidentTypeID), DescriptionField = typeof(MATIncidentType.description))]
		[PXUIField(DisplayName = "Incident Type", Visibility = PXUIVisibility.SelectorVisible)]
		[PX.Data.EP.PXFieldDescription]
		public virtual String IncidentType
		{
			get;
			set;
		}
		#endregion

		#region IncidentNbr
		/// <inheritdoc cref="IncidentNbr"/>
		public abstract class incidentNbr : PX.Data.BQL.BqlString.Field<incidentNbr> { }
		
		[PXDBString(15, IsKey = true, IsUnicode = true, InputMask = ">CCCCCCCCCCCCCCC")]
		[PXDefault()]
		[PXUIField(DisplayName = "Incident Nbr.", Visibility = PXUIVisibility.SelectorVisible)]
		[PXSelector(typeof(Search<MATIncident.incidentNbr,
			Where<MATIncident.incidentType, Equal<Optional<MATIncident.incidentType>>,
				And<Where<Exists<Select<MATIncidentType,
						Where<MATIncidentType.incidentTypeID, Equal<MATIncident.incidentType>>>>>>>,
			 OrderBy<Desc<MATIncident.incidentNbr>>>), Filterable = true)]
		[AutoNumber(typeof(Search<MATIncidentType.numberingID,
			Where<MATIncidentType.incidentTypeID, Equal<Current<MATIncident.incidentType>>>>),
			typeof(MATIncident.incidentDate))]
		[PX.Data.EP.PXFieldDescription]
		public virtual String IncidentNbr
		{
			get;
			set;
		}
		#endregion
		#region IncidentDate
		/// <inheritdoc cref="IncidentDate"/>
		public abstract class incidentDate : PX.Data.BQL.BqlDateTime.Field<incidentDate> { }
		
		[PXDBDate]
		[PXDefault(typeof(AccessInfo.businessDate))]
		[PXUIField(DisplayName = "Date", Visibility = PXUIVisibility.SelectorVisible)]
		public virtual DateTime? IncidentDate
		{
			get;
			set;
		}
		#endregion

		#region IncidentClass
		/// <inheritdoc cref="IncidentClass"/>
		public abstract class incidentClass : PX.Data.BQL.BqlString.Field<incidentClass> { }

		[PXDBString(20, IsFixed = true, InputMask = ">aaaaaaaaaa")]
		[PXDefault]
		[PXSelector(typeof(Search<MATIncidentClass.incidentClassID,
			Where<MATIncidentClass.incidentTypeID, Equal<Current<MATIncident.incidentType>>>>),
			DescriptionField = typeof(MATIncidentClass.description))]
		[PXUIField(DisplayName = "Incident Class", Visibility = PXUIVisibility.SelectorVisible)]
		[PX.Data.EP.PXFieldDescription]
		public virtual String IncidentClass
		{
			get;
			set;
		}
		#endregion

		#region Status
		/// <inheritdoc cref="Status"/>
		public abstract class status : PX.Data.BQL.BqlString.Field<status> { }
		
		[PXDBString(1, IsFixed = true)]
		[PXUIField(DisplayName = "Status", Visibility = PXUIVisibility.SelectorVisible, Enabled = false)]
		[MATIncidentStatus.List]
		[PXDefault(MATIncidentStatus.NewIncident)]
		public virtual String Status
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

		#region CompletionDate
		[PXDBDate]
		[PXUIField(DisplayName = "Completion Date")]
		public virtual DateTime? CompletionDate { get; set; }
		public abstract class completionDate : PX.Data.BQL.BqlDateTime.Field<completionDate> { }
		#endregion

		#region BAccountID
		[PXDBInt]
		[PXUIField(DisplayName = "BAccount ID")]
		[PXSelector(typeof(Search<EPEmployee.bAccountID>), SubstituteKey = typeof(EPEmployee.acctCD))]
		public virtual int? BAccountID { get; set; }
		public abstract class bAccountID : PX.Data.BQL.BqlInt.Field<bAccountID> { }
		#endregion


		#region FixedAssetID
		public abstract class fixedAssetID : PX.Data.BQL.BqlInt.Field<fixedAssetID> { }

		[PXDBInt]
		[PXSelector(typeof(Search<FixedAsset.assetID, Where<FixedAsset.recordType, NotEqual<FARecordType.classType>>>),
			SubstituteKey = typeof(FixedAsset.assetCD),
			DescriptionField = typeof(FixedAsset.description))]
		[PXUIField(DisplayName = "Fixed Asset")]
		public virtual Int32? FixedAssetID
		{
			get;
			set;
		}
		#endregion


		#region Tstamp
		[PXDBTimestamp()]
		[PXUIField(DisplayName = "Tstamp")]
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

	public class MATIncidentTypeConstants
	{
		public const string People = "PP";
		public const string Property = "PR";
		public const string IT = "IT";

		public class people : PX.Data.BQL.BqlString.Constant<people> { public people() : base(People) { } }
		public class property : PX.Data.BQL.BqlString.Constant<property> { public property() : base(Property) { } }
		public class iT : PX.Data.BQL.BqlString.Constant<iT> { public iT() : base(IT) { } }
	}

	public class MATIncidentStatus
	{
		public class ListAttribute : PXStringListAttribute
		{
			public static readonly (string, string)[] ValuesToLabels = new[]
			{
				(NewIncident, "New"),
					(Voided, "Voided"),
					(InProcess, "In Review"),
					(Completed, "Closed")
			};

			public ListAttribute() : base(ValuesToLabels) { }
		}

		public const string NewIncident = "N";
		public const string InProcess = "P";
		public const string Voided = "V";
		public const string Completed = "C";

		public class voided : PX.Data.BQL.BqlString.Constant<voided>
		{
			public voided() : base(Voided) { }
		}
		
		public class newIncident : PX.Data.BQL.BqlString.Constant<newIncident>
		{
			public newIncident() : base(NewIncident) { }
		}
		
		public class inProcess : PX.Data.BQL.BqlString.Constant<inProcess>
		{
			public inProcess() : base(InProcess) { }
		}
		
		public class completed : PX.Data.BQL.BqlString.Constant<completed>
		{
			public completed() : base(Completed) { }
		}
		
	}


}

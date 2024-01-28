using System;
using PX.Data;
using PX.Data.BQL;
using PX.Objects.CR;

namespace ESGHackathon2024
{
    [Serializable]
    [PXCacheName("MATTrainingAssign")]
    public class MATTrainingAssign : IBqlTable
    {
        #region BAccountID
        [PXDBInt(IsKey = true)]
        [PXUIField(DisplayName = "BAccount ID")]
        [PXSelector(typeof(Search<BAccount.bAccountID>), SubstituteKey = typeof(BAccount.acctCD), DescriptionField = typeof(BAccount.acctName))]
        public virtual int? BAccountID { get; set; }
        public abstract class bAccountID : PX.Data.BQL.BqlInt.Field<bAccountID> { }
        #endregion

        #region TrainingID
        [PXDBInt(IsKey = true)]
        [PXUIField(DisplayName = "Training ID")]
        [PXSelector(typeof(Search<MATTraining.trainingID>), SubstituteKey = typeof(MATTraining.trainingCD), DescriptionField = typeof(MATTraining.descr))]
        public virtual int? TrainingID { get; set; }
        public abstract class trainingID : PX.Data.BQL.BqlInt.Field<trainingID> { }
        #endregion

        #region CompletionDate
        [PXDBDate()]
        [PXUIField(DisplayName = "Completion Date")]
        public virtual DateTime? CompletionDate { get; set; }
        public abstract class completionDate : PX.Data.BQL.BqlDateTime.Field<completionDate> { }
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
}
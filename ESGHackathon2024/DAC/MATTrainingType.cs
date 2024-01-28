using System;
using PX.Data;
using PX.Data.BQL;

namespace ESGHackathon2024
{
    [Serializable]
    [PXCacheName("MATTrainingType")]
    public class MATTrainingType : IBqlTable
    {
        #region TrainingTypeID
        [PXDBIdentity(IsKey = true)]
        [PXSelector(typeof(Search<trainingTypeID>), SubstituteKey = typeof(trainingTypeCD), DescriptionField = typeof(descr))]
        public virtual int? TrainingTypeID { get; set; }
        public abstract class trainingTypeID : PX.Data.BQL.BqlInt.Field<trainingTypeID> { }
        #endregion

        #region TrainingTypeCD
        [PXDBString(30, IsUnicode = true, InputMask = "")]
        [PXUIField(DisplayName = "Training Type")]
        [PXDefault()]
        public virtual string TrainingTypeCD { get; set; }
        public abstract class trainingTypeCD : PX.Data.BQL.BqlString.Field<trainingTypeCD> { }
        #endregion

        #region Descr
        [PXDBString(256, IsUnicode = true, InputMask = "")]
        [PXDefault()]
        [PXUIField(DisplayName = "Description")]
        public virtual string Descr { get; set; }
        public abstract class descr : PX.Data.BQL.BqlString.Field<descr> { }
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
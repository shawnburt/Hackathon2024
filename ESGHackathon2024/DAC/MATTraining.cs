using System;
using PX.Data;
using PX.Data.BQL;
using PX.Data.ReferentialIntegrity.Attributes;

namespace ESGHackathon2024
{
    [Serializable]
    [PXCacheName("MATTraining")]
    public class MATTraining : IBqlTable
    {
        public class PK : PrimaryKeyOf<MATTraining>.By<trainingID>
        {
            public static MATTraining Find(PXGraph graph, int? trainingID) => FindBy(graph, trainingID);
        }

        #region TrainingID
        [PXDBIdentity(IsKey = true)]
        [PXSelector(typeof(Search<MATTraining.trainingID>), SubstituteKey = typeof(trainingCD), DescriptionField = typeof(descr))]
        public virtual int? TrainingID { get; set; }
        public abstract class trainingID : PX.Data.BQL.BqlInt.Field<trainingID> { }
        #endregion

        #region TrainingCD
        [PXDBString(30, IsUnicode = true, InputMask = "")]
        [PXUIField(DisplayName = "Training")]
        [PXDefault()]
        public virtual string TrainingCD { get; set; }
        public abstract class trainingCD : PX.Data.BQL.BqlString.Field<trainingCD> { }
        #endregion

        #region TrainingTypeID
        [PXDBInt()]
        [PXUIField(DisplayName = "Training Type ID")]
        [PXSelector(typeof(Search<MATTrainingType.trainingTypeID>), SubstituteKey = typeof(MATTrainingType.trainingTypeCD), DescriptionField = typeof(MATTrainingType.descr))]
        [PXDefault()]
        public virtual int? TrainingTypeID { get; set; }
        public abstract class trainingTypeID : PX.Data.BQL.BqlInt.Field<trainingTypeID> { }
        #endregion

        #region Descr
        [PXDBString(256, IsUnicode = true, InputMask = "")]
        [PXDefault]
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
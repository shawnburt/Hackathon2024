using System;
using PX.Data;
using PX.Data.BQL;
using PX.Data.ReferentialIntegrity.Attributes;

namespace ESGHackathon2024
{
    [Serializable]
    [PXCacheName("Training")]
    [PXPrimaryGraph(typeof(MATTrainingMaint))]
    public class MATTraining : IBqlTable
    {
        #region Keys
        public class PK : PrimaryKeyOf<MATTraining>.By<trainingID>
        {
            public static MATTraining Find(PXGraph graph, int? trainingID, PKFindOptions options = PKFindOptions.None) => FindBy(graph, trainingID, options);
        }
        public class UK : PrimaryKeyOf<MATTraining>.By<trainingCD>
        {
            public static MATTraining Find(PXGraph graph, string trainingCD, PKFindOptions options = PKFindOptions.None) => FindBy(graph, trainingCD, options);
        }
        #endregion


        #region TrainingID
        [PXDBIdentity]
        [PXSelector(typeof(Search<trainingID>), SubstituteKey = typeof(trainingCD), DescriptionField = typeof(descr))]
        public virtual int? TrainingID { get; set; }
        public abstract class trainingID : BqlInt.Field<trainingID> { }
        #endregion

        #region TrainingCD
        [PXDBString(30, IsKey = true, IsUnicode = true, InputMask = "")]
        [PXDefault]
        [PXUIField(DisplayName = "Training")]
        public virtual string TrainingCD { get; set; }
        public abstract class trainingCD : BqlString.Field<trainingCD> { }
        #endregion

        #region TrainingTypeID
        [PXDBInt]
        [PXUIField(DisplayName = "Training Type ID")]
        [PXDefault]
        [PXSelector(typeof(Search<MATTrainingType.trainingTypeID>), SubstituteKey = typeof(MATTrainingType.trainingTypeCD), DescriptionField = typeof(MATTrainingType.descr))]
        public virtual int? TrainingTypeID { get; set; }
        public abstract class trainingTypeID : BqlInt.Field<trainingTypeID> { }
        #endregion

        #region Descr
        [PXDBString(256, IsUnicode = true, InputMask = "")]
        [PXDefault]
        [PXUIField(DisplayName = "Description")]
        public virtual string Descr { get; set; }
        public abstract class descr : BqlString.Field<descr> { }
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
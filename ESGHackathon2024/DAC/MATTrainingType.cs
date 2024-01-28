using System;
using PX.Data;
using PX.Data.BQL;
using PX.Data.ReferentialIntegrity.Attributes;

namespace ESGHackathon2024
{
    [Serializable]
    [PXCacheName(MATMessages.TrainingType, PXDacType.Catalogue)]
    [PXPrimaryGraph(typeof(MATTrainingTypeMaint))]
    public class MATTrainingType : IBqlTable
    {
        #region Keys
        public class PK : PrimaryKeyOf<MATTrainingType>.By<trainingTypeID>
        {
            public static MATTrainingType Find(PXGraph graph, int? trainingTypeID, PKFindOptions options = PKFindOptions.None) => FindBy(graph, trainingTypeID, options);
        }
        public class UK : PrimaryKeyOf<MATTrainingType>.By<trainingTypeCD>
        {
            public static MATTrainingType Find(PXGraph graph, string trainingTypeCD, PKFindOptions options = PKFindOptions.None) => FindBy(graph, trainingTypeCD, options);
        }
        #endregion


        #region TrainingTypeID
        [PXDBIdentity]
        [PXSelector(typeof(Search<trainingTypeID>), SubstituteKey = typeof(trainingTypeCD), DescriptionField = typeof(descr))]
        public virtual int? TrainingTypeID { get; set; }
        public abstract class trainingTypeID : BqlInt.Field<trainingTypeID> { }
        #endregion

        #region TrainingTypeCD
        [PXDBString(30, IsKey = true, IsUnicode = true, InputMask = "")]
        [PXDefault]
        [PXUIField(DisplayName = MATMessages.TrainingType)]
        public virtual string TrainingTypeCD { get; set; }
        public abstract class trainingTypeCD : BqlString.Field<trainingTypeCD> { }
        #endregion

        #region Descr
        [PXDBString(256, IsUnicode = true, InputMask = "")]
        [PXDefault]
        [PXUIField(DisplayName = MATMessages.Description)]
        public virtual string Descr { get; set; }
        public abstract class descr : BqlString.Field<descr> { }
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
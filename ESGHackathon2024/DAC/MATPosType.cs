using System;
using PX.Data;
using PX.Data.BQL;
using PX.Data.ReferentialIntegrity.Attributes;

namespace Hackathon2024
{
    [Serializable]
    [PXCacheName("MATPosType")]
    [PXPrimaryGraph(typeof(MATPosTypeMaint))]
    public class MATPosType : IBqlTable
    {
        #region Keys
        public class PK : PrimaryKeyOf<MATPosType>.By<posTypeID>
        {
            public static MATPosType Find(PXGraph graph, int? posTypeID, PKFindOptions options = PKFindOptions.None) => FindBy(graph, posTypeID, options);
        }
        public class UK : PrimaryKeyOf<MATPosType>.By<posTypeCD>
        {
            public static MATPosType Find(PXGraph graph, string posTypeCD, PKFindOptions options = PKFindOptions.None) => FindBy(graph, posTypeCD, options);
        }
        #endregion


        #region PosTypeID
        [PXDBIdentity]
        [PXSelector(typeof(Search<posTypeID>), SubstituteKey = typeof(posTypeCD), DescriptionField = typeof(descr))]
        public virtual int? PosTypeID { get; set; }
        public abstract class posTypeID : BqlInt.Field<posTypeID> { }
        #endregion

        #region PosTypeCD
        [PXDBString(30, IsKey = true, IsUnicode = true, InputMask = "")]
        [PXDefault]
        [PXUIField(DisplayName = "Position Type")]
        public virtual string PosTypeCD { get; set; }
        public abstract class posTypeCD : BqlString.Field<posTypeCD> { }
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
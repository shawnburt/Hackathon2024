using System;
using PX.Data;
using PX.Data.BQL;
using PX.Data.ReferentialIntegrity.Attributes;

namespace ESGHackathon2024
{
    [Serializable]
    [PXCacheName("Position Class")]
    [PXPrimaryGraph(typeof(MATPosClassMaint))]
    public class MATPosClass : IBqlTable
    {
        #region Keys
        public class PK : PrimaryKeyOf<MATPosClass>.By<posClassID>
        {
            public static MATPosClass Find(PXGraph graph, int? posClassID, PKFindOptions options = PKFindOptions.None) => FindBy(graph, posClassID, options);
        }
        public class UK : PrimaryKeyOf<MATPosClass>.By<posClassCD>
        {
            public static MATPosClass Find(PXGraph graph, string posClassCD, PKFindOptions options = PKFindOptions.None) => FindBy(graph, posClassCD, options);
        }
        #endregion


        #region PosClassID
        [PXDBIdentity]
        [PXUIField(DisplayName = "Pos Class ID")]
        public virtual int? PosClassID { get; set; }
        public abstract class posClassID : BqlInt.Field<posClassID> { }
        #endregion

        #region PosClassCD
        [PXDBString(30, IsKey = true, IsUnicode = true, InputMask = "")]
        [PXDefault]
        [PXUIField(DisplayName = "Position Class")]
        public virtual string PosClassCD { get; set; }
        public abstract class posClassCD : BqlString.Field<posClassCD> { }
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
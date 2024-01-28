using System;
using PX.Data;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Data.BQL;

namespace ESGHackathon2024
{
    [Serializable]
    [PXCacheName("Race", PXDacType.Catalogue)]
    [PXPrimaryGraph(typeof(MATRaceMaint))]
    public partial class MATRace : IBqlTable
    {
        #region Keys
        public class PK : PrimaryKeyOf<MATRace>.By<raceID>
        {
            public static MATRace Find(PXGraph graph, string raceID, PKFindOptions options = PKFindOptions.None) => FindBy(graph, raceID, options);
        }
        #endregion


        #region RaceID
        [PXDBString(30, IsKey = true, IsUnicode = true, InputMask = "")]
        [PXDefault]
        [PXUIField(DisplayName = "Race", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string RaceID { get; set; }
        public abstract class raceID : BqlString.Field<raceID> { }
        #endregion

        #region Description
        [PXDBString(256, IsUnicode = true, InputMask = "")]
        [PXUIField(DisplayName = "Description", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Description { get; set; }
        public abstract class description : BqlString.Field<description> { }
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
using PX.Data;
using PX.Data.BQL;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Objects.EP;

namespace ESGHackathon2024
{
    // Acuminator disable once PX1016 ExtensionDoesNotDeclareIsActiveMethod extension should be constantly active
    public sealed class EPPositionExt : PXCacheExtension<EPPosition>
    {
        #region Keys
        public static class FK
        {
            public class PosClass : MATPosClass.PK.ForeignKeyOf<EPPosition>.By<usrPosClassID> { }
            public class PosType : MATPosType.PK.ForeignKeyOf<EPPosition>.By<usrPosTypeID> { }
        }
        #endregion


        #region UsrPosClassID
        [PXDBInt]
        [PXUIField(DisplayName = MATMessages.PositionClass)]
        [PXSelector(typeof(Search<MATPosClass.posClassID>), SubstituteKey = typeof(MATPosClass.posClassCD), DescriptionField = typeof(MATPosClass.descr))]
        [PXForeignReference(typeof(FK.PosClass))]
        public int? UsrPosClassID { get; set; }
        public abstract class usrPosClassID : BqlInt.Field<usrPosClassID> { }
        #endregion

        #region UsrPosTypeID
        [PXDBInt]
        [PXUIField(DisplayName = MATMessages.PositionType)]
        [PXSelector(typeof(Search<MATPosType.posTypeID>), SubstituteKey = typeof(MATPosType.posTypeCD), DescriptionField = typeof(MATPosType.descr))]
        [PXForeignReference(typeof(FK.PosType))]
        public int? UsrPosTypeID { get; set; }
        public abstract class usrPosTypeID : BqlInt.Field<usrPosTypeID> { }
        #endregion
    }
}
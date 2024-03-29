using System;
using PX.Data;
using PX.Data.BQL;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Objects.CR;
using PX.Objects.IN;
using CR = PX.Objects.CR;
using IN = PX.Objects.IN;

namespace ESGHackathon2024
{
    [Serializable]
    [PXCacheName(MATMessages.BusinessAccountItemUsage)]
    [PXPrimaryGraph(typeof(MATBAccountItemUsageMaint))]
    public class MATBAccountItemUsage : IBqlTable
    {
        #region Keys
        public class PK : PrimaryKeyOf<MATBAccountItemUsage>.By<bAccountID, inventoryID, asOfDate>
        {
            public static MATBAccountItemUsage Find(PXGraph graph, int? bAccountID, int? inventoryID, DateTime? asOfDate, PKFindOptions options = PKFindOptions.None) => FindBy(graph, bAccountID, inventoryID, asOfDate, options);
        }

        public static class FK
        {
            public class BAccount : CR.BAccount.PK.ForeignKeyOf<MATBAccountItemUsage>.By<bAccountID> { }
            public class InventoryItem : IN.InventoryItem.PK.ForeignKeyOf<MATBAccountItemUsage>.By<inventoryID> { }
        }
        #endregion


        #region BAccountID
        [PXDBInt(IsKey = true)]
        [PXUIField(DisplayName = MATMessages.BusinessAccount, TabOrder = 0)]
        [PXDimensionSelector("BIZACCT", typeof(Search2<BAccount.bAccountID,
            LeftJoin<Contact,
                On<Contact.bAccountID, Equal<BAccount.bAccountID>, And<Contact.contactID, Equal<BAccount.defContactID>>>,
            LeftJoin<Address,
                On<Address.bAccountID, Equal<BAccount.bAccountID>, And<Address.addressID, Equal<BAccount.defAddressID>>>>>,
            Where<
                BAccount.type, Equal<BAccountType.customerType>,
                Or<BAccount.type, Equal<BAccountType.prospectType>,
                Or<BAccount.type, Equal<BAccountType.vendorType>,
                Or<BAccount.type, Equal<BAccountType.combinedType>>>>>>),
            substituteKey: typeof(BAccount.acctCD),
            fieldList: new[]
            {
                typeof(BAccount.acctCD),
                typeof(BAccount.acctName),
                typeof(BAccount.type),
                typeof(BAccount.classID),
                typeof(BAccount.status),
                typeof(Contact.phone1),
                typeof(Address.city),
                typeof(Address.countryID)
            },
            DescriptionField = typeof(BAccount.acctName))]
        [PXForeignReference(typeof(FK.BAccount))]
        public virtual int? BAccountID { get; set; }
        public abstract class bAccountID : BqlInt.Field<bAccountID> { }
        #endregion

        #region InventoryID
        [Inventory(IsKey = true, DisplayName = MATMessages.InventoryID)]
        [PXForeignReference(typeof(FK.InventoryItem))]
        public virtual int? InventoryID { get; set; }
        public abstract class inventoryID : BqlInt.Field<inventoryID> { }
        #endregion

        #region AsOfDate
        [PXDBDate(IsKey = true)]
        [PXUIField(DisplayName = MATMessages.AsOfDate)]
        public virtual DateTime? AsOfDate { get; set; }
        public abstract class asOfDate : BqlDateTime.Field<asOfDate> { }
        #endregion

        #region EnvironmentallyControlled
        [PXDBBool]
        [PXUIField(DisplayName = MATMessages.EnvironmentallyControlled)]
        public virtual bool? EnvironmentallyControlled { get; set; }
        public abstract class environmentallyControlled : BqlBool.Field<environmentallyControlled> { }
        #endregion

        #region CarbonEmissions
        [PXDBQuantity]
        [PXUIField(DisplayName = MATMessages.CarbonEmissions)]
        public virtual decimal? CarbonEmissions { get; set; }
        public abstract class carbonEmissions : BqlDecimal.Field<carbonEmissions> { }
        #endregion

        #region CarbonEmissionsUOM
        [INUnit(DisplayName = MATMessages.CarbonEmissionsUOM)]
        public virtual string CarbonEmissionsUOM { get; set; }
        public abstract class carbonEmissionsUOM : BqlString.Field<carbonEmissionsUOM> { }
        #endregion

        #region ElectricUsage
        [PXDBQuantity]
        [PXUIField(DisplayName = MATMessages.ElectricUsage)]
        public virtual decimal? ElectricUsage { get; set; }
        public abstract class electricUsage : BqlDecimal.Field<electricUsage> { }
        #endregion

        #region ElectricUsageUOM
        [INUnit(DisplayName = MATMessages.ElectricUsageUOM)]
        public virtual string ElectricUsageUOM { get; set; }
        public abstract class electricUsageUOM : BqlString.Field<electricUsageUOM> { }
        #endregion

        #region GasUsage
        [PXDBQuantity]
        [PXUIField(DisplayName = MATMessages.GasUsage)]
        public virtual decimal? GasUsage { get; set; }
        public abstract class gasUsage : BqlDecimal.Field<gasUsage> { }
        #endregion

        #region GasUsageUOM
        [INUnit(DisplayName = MATMessages.GasUsageUOM)]
        public virtual string GasUsageUOM { get; set; }
        public abstract class gasUsageUOM : BqlString.Field<gasUsageUOM> { }
        #endregion

        #region OilUsage
        [PXDBQuantity]
        [PXUIField(DisplayName = MATMessages.OilUsage)]
        public virtual decimal? OilUsage { get; set; }
        public abstract class oilUsage : BqlDecimal.Field<oilUsage> { }
        #endregion

        #region OilUsagewUOM
        [INUnit(DisplayName = MATMessages.OilUsageUOM)]
        public virtual string OilUsagewUOM { get; set; }
        public abstract class oilUsagewUOM : BqlString.Field<oilUsagewUOM> { }
        #endregion

        #region WaterConsumption
        [PXDBQuantity]
        [PXUIField(DisplayName = MATMessages.WaterConsumption)]
        public virtual decimal? WaterConsumption { get; set; }
        public abstract class waterConsumption : BqlDecimal.Field<waterConsumption> { }
        #endregion

        #region WaterConsumptionUOM
        [INUnit(DisplayName = MATMessages.WaterConsumptionUOM)]
        public virtual string WaterConsumptionUOM { get; set; }
        public abstract class waterConsumptionUOM : BqlString.Field<waterConsumptionUOM> { }
        #endregion

        #region RecycledWaste
        [PXDBQuantity]
        [PXUIField(DisplayName = MATMessages.RecycledWaste)]
        public virtual decimal? RecycledWaste { get; set; }
        public abstract class recycledWaste : BqlDecimal.Field<recycledWaste> { }
        #endregion

        #region RecycledWasteUOM
        [INUnit(DisplayName = MATMessages.RecycledWasteUOM)]
        public virtual string RecycledWasteUOM { get; set; }
        public abstract class recycledWasteUOM : BqlString.Field<recycledWasteUOM> { }
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
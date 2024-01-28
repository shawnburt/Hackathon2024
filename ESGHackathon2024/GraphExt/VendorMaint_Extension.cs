using PX.Data;
using PX.Objects.AP;
using PX.Data.BQL.Fluent;

namespace ESGHackathon2024
{
    // Acuminator disable once PX1016 ExtensionDoesNotDeclareIsActiveMethod extension should be constantly active
    public class VendorMaint_Extension : PXGraphExtension<VendorMaint>
    {
        public SelectFrom<MATBAccountItemUsage>
            .Where<MATBAccountItemUsage.bAccountID.IsEqual<Vendor.bAccountID.FromCurrent>>
            .View ESGData;

        protected void _(Events.RowInserting<MATBAccountItemUsage> e)
        {
            if (e.Row == null) return;

            ESGData.SetValueExt<MATBAccountItemUsage.bAccountID>(e.Row, Base.CurrentVendor.Current?.BAccountID);
        }
    }
}
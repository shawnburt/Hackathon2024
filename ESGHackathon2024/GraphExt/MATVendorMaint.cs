using Hackathon2024;
using PX.Data;
using PX.Objects.AP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESGHackathon2024.GraphExt
{
    public class MATVendorMaint:PXGraphExtension<VendorMaint>
    {
        public PXSelect<MATBAccountItemUsage, Where<MATBAccountItemUsage.bAccountID, Equal<Current<Vendor.bAccountID>>>> ESGData;
        protected void _(Events.RowInserting<MATBAccountItemUsage> e)
        {
            if(e.Row != null) {
             var row=e.Row;
                row.BAccountID = Base.CurrentVendor.Current?.BAccountID;
            }
        }
    }
}

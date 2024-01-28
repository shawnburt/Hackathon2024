using PX.Data;
using PX.Objects.EP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESGHackathon2024.GraphExt
{
    public class MATEmployeeMaint : PXGraphExtension<EmployeeMaint>
    {
        public PXSelect<MATTrainingAssign, Where<MATTrainingAssign.bAccountID, Equal<Current<EPEmployee.bAccountID>>>> MATTraining;
        protected void _(Events.RowInserting<MATTrainingAssign> e)
        {
            if(e.Row!=null)
                {
                var row = e.Row;
                row.BAccountID = Base.Employee.Current?.BAccountID;
            }
        }
    }
}

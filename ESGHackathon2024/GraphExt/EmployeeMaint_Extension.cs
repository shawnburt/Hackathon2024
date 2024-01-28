using PX.Data;
using PX.Objects.EP;
using PX.Data.BQL.Fluent;

namespace ESGHackathon2024
{
    // Acuminator disable once PX1016 ExtensionDoesNotDeclareIsActiveMethod extension should be constantly active
    public class EmployeeMaint_Extension : PXGraphExtension<EmployeeMaint>
    {
        public SelectFrom<MATTrainingAssign>
            .Where<MATTrainingAssign.bAccountID.IsEqual<EPEmployee.bAccountID.FromCurrent>>
            .View MATTraining;

        protected void _(Events.RowInserting<MATTrainingAssign> e)
        {
            if (e.Row == null) return;

            MATTraining.SetValueExt<MATTrainingAssign.bAccountID>(e.Row, Base.Employee.Current?.BAccountID);
        }
    }
}
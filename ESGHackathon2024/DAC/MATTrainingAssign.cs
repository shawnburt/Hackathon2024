using System;
using PX.Data;
using PX.Objects.CR;

namespace ESGHackathon2024
{
  [Serializable]
  [PXCacheName("MATTrainingAssign")]
  public class MATTrainingAssign : IBqlTable
  {

    #region BAccountID
    [PXDBInt(IsKey = true)]
    [PXUIField(DisplayName = "BAccount ID")]
        [PXSelector(typeof(Search<BAccount.bAccountID>),SubstituteKey =typeof(BAccount.acctCD),DescriptionField =typeof(BAccount.acctName))]
    public virtual int? BAccountID { get; set; }
    public abstract class bAccountID : PX.Data.BQL.BqlInt.Field<bAccountID> { }
    #endregion

    #region TrainingID
    [PXDBInt(IsKey = true)]
    [PXUIField(DisplayName = "Training ID")]
        [PXSelector(typeof(Search<MATTraining.trainingID>),SubstituteKey =typeof(MATTraining.trainingCD),DescriptionField =typeof(MATTraining.descr))]
    public virtual int? TrainingID { get; set; }
    public abstract class trainingID : PX.Data.BQL.BqlInt.Field<trainingID> { }
    #endregion

    #region CompletionDate
    [PXDBDate()]
    [PXUIField(DisplayName = "Completion Date")]
    public virtual DateTime? CompletionDate { get; set; }
    public abstract class completionDate : PX.Data.BQL.BqlDateTime.Field<completionDate> { }
    #endregion
  }
}
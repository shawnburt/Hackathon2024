using System;
using PX.Data;

namespace ESGHackathon2024
{
  [Serializable]
  [PXCacheName("MATTrainingAssign")]
  public class MATTrainingAssign : IBqlTable
  {
    #region CompayID
    [PXDBInt(IsKey = true)]
    [PXUIField(DisplayName = "Compay ID")]
    public virtual int? CompayID { get; set; }
    public abstract class compayID : PX.Data.BQL.BqlInt.Field<compayID> { }
    #endregion

    #region BAccountID
    [PXDBInt(IsKey = true)]
    [PXUIField(DisplayName = "BAccount ID")]
    public virtual int? BAccountID { get; set; }
    public abstract class bAccountID : PX.Data.BQL.BqlInt.Field<bAccountID> { }
    #endregion

    #region TrainingID
    [PXDBInt(IsKey = true)]
    [PXUIField(DisplayName = "Training ID")]
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
using System;
using PX.Data;

namespace ESGHackathon2024
{
  [Serializable]
  [PXCacheName("MATTraining")]
  public class MATTraining : IBqlTable
  {
    #region TrainingID
    [PXDBIdentity(IsKey = true)]
        [PXSelector(typeof(Search<MATTraining.trainingID>),SubstituteKey =typeof(trainingCD),DescriptionField =typeof(descr))]
    public virtual int? TrainingID { get; set; }
    public abstract class trainingID : PX.Data.BQL.BqlInt.Field<trainingID> { }
    #endregion

    #region TrainingTypeID
    [PXDBInt()]
    [PXUIField(DisplayName = "Training Type ID")]
        [PXSelector(typeof(Search<MATTrainingType.trainingTypeID>),SubstituteKey =typeof(MATTrainingType.trainingTypeCD),DescriptionField =typeof(descr))]
        [PXDefault()]
    public virtual int? TrainingTypeID { get; set; }
    public abstract class trainingTypeID : PX.Data.BQL.BqlInt.Field<trainingTypeID> { }
    #endregion

    #region Descr
    [PXDBString(1000, IsUnicode = true, InputMask = "")]
    [PXUIField(DisplayName = "Descr")]
    public virtual string Descr { get; set; }
    public abstract class descr : PX.Data.BQL.BqlString.Field<descr> { }
    #endregion

    #region TrainingCD
    [PXDBString(10, IsUnicode = true, InputMask = "")]
    [PXUIField(DisplayName = "Training CD")]
        [PXDefault()]
    public virtual string TrainingCD { get; set; }
    public abstract class trainingCD : PX.Data.BQL.BqlString.Field<trainingCD> { }
    #endregion
  }
}
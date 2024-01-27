using System;
using PX.Data;

namespace ESGHackathon2024
{
  [Serializable]
  [PXCacheName("MATTrainingType")]
  public class MATTrainingType : IBqlTable
  {
    #region TrainingTypeID
    [PXDBIdentity(IsKey = true)]
        [PXSelector(typeof(MATTrainingType),SubstituteKey =typeof(trainingTypeCD),DescriptionField =typeof(descr))]
    public virtual int? TrainingTypeID { get; set; }
    public abstract class trainingTypeID : PX.Data.BQL.BqlInt.Field<trainingTypeID> { }
    #endregion

    #region TrainingTypeCD
    [PXDBString(10, IsUnicode = true, InputMask = "")]
    [PXUIField(DisplayName = "Training Type CD")]
    public virtual string TrainingTypeCD { get; set; }
    public abstract class trainingTypeCD : PX.Data.BQL.BqlString.Field<trainingTypeCD> { }
    #endregion

    #region Descr
    [PXDBString(1000, IsUnicode = true, InputMask = "")]
    [PXUIField(DisplayName = "Descr")]
    public virtual string Descr { get; set; }
    public abstract class descr : PX.Data.BQL.BqlString.Field<descr> { }
    #endregion
  }
}
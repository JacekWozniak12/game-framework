namespace UGF.Game
{
    /// <summary>
    /// Implements TimeScaleMultiplier
    /// </summary>
    public interface ICustomTimeScale
    {
        /// <summary>
        /// Sets modifier to TimeScaleMultiplier
        /// </summary>
         void SetObjectTimeScale(float TimeScaleMultiplier);
         
         /// <summary>
         /// Sets modifier to 0
         /// </summary>
         void SetDefaultTimeScale();
    }
}
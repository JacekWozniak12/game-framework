using UnityEngine;

namespace UGF.Game
{
    /// <summary>
    /// Interface for saving game data
    /// </summary>
    /// <typeparam name="T">Serializable type</typeparam>
    public interface ISave<T>
    {
        /// <summary>
        /// Handles data before save. It's suggested to pause GameAgent before saving
        /// </summary>
        void PrepareToSave();

        /// <summary>
        /// Handles data saving.
        /// </summary>
        /// <returns>If save was succesful</returns>
        bool Save();
    }
}
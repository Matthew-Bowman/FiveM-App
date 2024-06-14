// Last Modified: 14/06/2024

namespace FiveM_EventManager
{
    /// <summary>
    /// Interface <c>IVerifyJSON</c> verifies JSON formatted strings
    /// </summary>
    internal interface IVerifyJSON
    {
        /// <summary>
        /// Method <c>VerifyJSON</c> verifies a JSON formatted string
        /// </summary>
        /// <param name="pData">The string to verify</param>
        /// <returns>Whether the string is valid JSON or not</returns>
        bool VerifyJSON(string pData);
    }
}

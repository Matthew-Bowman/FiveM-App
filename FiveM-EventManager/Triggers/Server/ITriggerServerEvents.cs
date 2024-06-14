// Last Modified: 14/06/2024

namespace FiveM_EventManager
{
    /// <summary>
    /// Interface <c>ITriggerServerEvents</c> triggers a server event with data
    /// </summary>
    internal interface ITriggerServerEvents
    {
        /// <summary>
        /// Method <c>TriggerEvent</c>
        /// </summary>
        /// <param name="pEventName">The server event to trigger</param>
        /// <param name="pData">The data to send (JSON string)</param>
        void TriggerEvent(ServerEvent pEventName, string pData);
    }
}

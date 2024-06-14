// Last Modified: 14/06/2024

namespace FiveM_EventManager
{
    /// <summary>
    /// Interface <c>ITriggerEvents</c> triggers an event with supplied data
    /// </summary>
    internal interface ITriggerEvents
    {
        /// <summary>
        /// Method <c>TriggerEvent</c> triggers a server event and sends data
        /// </summary>
        /// <param name="pEventName">The event to be triggered</param>
        /// <param name="pData">The data to send (JSON string)</param>
        void TriggerEvent(ServerEvent pEventName, string pData);

        /// <summary>
        /// Method <c>TriggerEvent</c> triggers a client event and sends data
        /// </summary>
        /// <param name="pEventName">The event to be triggered</param>
        /// <param name="pData">The data to send (JSON string)</param>
        /// <param name="pDestination">The target client</param>
        void TriggerEvent(ClientEvent pEventName, string pData, int pDestination = -1);
    }
}

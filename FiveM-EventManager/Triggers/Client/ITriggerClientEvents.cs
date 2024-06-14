// Last Modified: 14/06/2024

namespace FiveM_EventManager
{
    /// <summary>
    /// Interface <c>ITriggerClientEvents</c> triggers a client event with data
    /// </summary>
    internal interface ITriggerClientEvents
    {
        /// <summary>
        /// Method <c>TriggerEvent</c>
        /// </summary>
        /// <param name="pEventName">The client event to trigger</param>
        /// <param name="pData">The data to send (JSON string)</param>
        /// <param name="pDestination">The target client</param>
        void TriggerEvent(ServerEvent pEventName, string pData, int pDestination = -1);
    }
}

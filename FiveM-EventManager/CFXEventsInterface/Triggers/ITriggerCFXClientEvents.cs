// Last Modified: 14/06/2024

namespace FiveM_EventManager.CFXEventsInterface
{
    /// <summary>
    /// Interface <c>ITriggerCFXClientEvents</c> triggers client events
    /// </summary>
    internal interface ITriggerCFXClientEvents
    {
        /// <summary>
        /// Method <c>TriggerClientEvent</c> triggers a client event
        /// </summary>
        /// <param name="pEventName">The client event to trigger</param>
        /// <param name="pData">The data to send (JSON string)</param>
        /// <param name="pDestination">The target client</param>
        void TriggerClientEvent(ClientEvent pEventName, string pData, int pDestination = -1);
    }
}

﻿// Last Modified: 14/06/2024

namespace FiveM_EventManager.CFXEventsInterface
{
    /// <summary>
    /// Interface <c>ITriggerCFXServerEvents</c> triggers server events
    /// </summary>
    internal interface ITriggerCFXServerEvents
    {
        /// <summary>
        /// Method <c>TriggerClientEvent</c> triggers a server event
        /// </summary>
        /// <param name="pEventName">The server event to trigger</param>
        /// <param name="pData">The data to send (JSON string)</param>
        void TriggerServerEvent(ServerEvent pEventName, string pData);
    }
}

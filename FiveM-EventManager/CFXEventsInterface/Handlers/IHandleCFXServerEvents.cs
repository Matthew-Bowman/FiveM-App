// Last Modified: 14/06/2024
using System;

namespace FiveM_EventManager.CFXEventsInterface
{
    /// <summary>
    /// Interface <c>IHandleCFXServerEvents</c> adds handlers for sever events coming from CFX Basescript
    /// </summary>
    internal interface IHandleCFXServerEvents
    {
        /// <summary>
        /// Method <c>AddEventHandler</c> adds a new handler for an event
        /// </summary>
        /// <param name="pEventName">The server event to listen for</param>
        /// <param name="pAction">The action to perform when the event is received</param>
        void AddEventHandler(ServerEvent pEventName, Action<string> pAction);
    }
}

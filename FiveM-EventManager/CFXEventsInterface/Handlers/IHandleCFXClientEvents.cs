// Last Modified: 14/06/2024

using System;

namespace FiveM_EventManager.CFXEventsInterface
{
    /// <summary>
    /// Interface <c>IHandleCFXClientEvents</c> adds handlers for client events coming from CFX Basescript
    /// </summary>
    internal interface IHandleCFXClientEvents
    {
        /// <summary>
        /// Method <c>AddEventHandler</c> adds a new handler for an event
        /// </summary>
        /// <param name="pEventName">The client event to listen for</param>
        /// <param name="pAction">The action to perform when the event is received</param>
        void AddEventHandler(ClientEvent pEventName, Action<string> pAction);
    }
}

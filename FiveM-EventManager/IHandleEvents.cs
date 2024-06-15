// Last Modified: 14/06/2024
using System;

namespace FiveM_EventManager
{
    /// <summary>
    /// Interface <c>IHandleEvents</c> combines events and their corrosponding handlers
    /// </summary>
    public interface IHandleEvents
    {
        /// <summary>
        /// Method <c>AddPseudoHandler</c> combines an event with an action
        /// </summary>
        /// <param name="pEventName">The triggering event</param>
        /// <param name="pAction">The action to be completed</param>
        void AddPseudoHandler(ServerEvent pEventName, Action<string> pAction);

        /// <summary>
        /// Method <c>AddPseudoHandler</c> combines an event with an action
        /// </summary>
        /// <param name="pEventName">The triggering event</param>
        /// <param name="pAction">The action to be completed</param>
        void AddPseudoHandler(ClientEvent pEventName, Action<string> pAction);

        /// <summary>
        /// Method <c>CompileEvents</c> should be ran after the last <c>AddPseudoHandler</c> to implement all handlers
        /// </summary>
        void CompileEvents();
    }
}

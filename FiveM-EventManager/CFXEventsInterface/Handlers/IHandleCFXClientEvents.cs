using System;

namespace FiveM_EventManager.CFXEventsInterface
{
    internal interface IHandleCFXClientEvents
    {
        void AddingNewEventHandler(ClientEvent pEventName, Action<string> pAction);
    }
}

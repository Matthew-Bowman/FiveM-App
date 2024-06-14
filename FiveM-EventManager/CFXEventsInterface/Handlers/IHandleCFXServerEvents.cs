using System;

namespace FiveM_EventManager.CFXEventsInterface
{
    internal interface IHandleCFXServerEvents
    {
        void AddEventHandler(ServerEvent pEventName, Action<string> pAction);
    }
}

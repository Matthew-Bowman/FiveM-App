using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveM_EventManager
{
    internal interface IManageEvents
    {
        void AddPseudoHandler(ServerEvent pEventName, Action<string> pAction);
        void AddPseudoHandler(ClientEvent pEventName, Action<string> pAction);

        void TriggerEvent(ServerEvent pEventName, string pData);
        void TriggerEvent(ClientEvent pEventName, string pData);
        void TriggerEvent(ClientEvent pEventName, int pDestination);

        void CompileEvents();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveM_EventManager
{
    internal interface ITriggerEvents
    {
        void TriggerEvent(ServerEvent pEventName, string pData);
        void TriggerEvent(ClientEvent pEventName, string pData);
        void TriggerEvent(ClientEvent pEventName, int pDestination);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveM_EventManager.CFXEventsInterface
{
    internal interface ITriggerCFXClientEvents
    {
        void TriggerClientEvent(ClientEvent pEventName, string pData, int pDestination = -1);
    }
}

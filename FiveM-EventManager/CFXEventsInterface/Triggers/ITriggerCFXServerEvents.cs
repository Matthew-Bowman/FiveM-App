using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveM_EventManager.CFXEventsInterface
{
    internal interface ITriggerCFXServerEvents
    {
        void TriggerServerEvent(ServerEvent pEventName, string pData);
    }
}

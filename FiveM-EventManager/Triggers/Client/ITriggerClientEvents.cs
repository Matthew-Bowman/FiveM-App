using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveM_EventManager
{
    internal interface ITriggerClientEvents
    {
        void TriggerEvent(ServerEvent pEventName, string pData, int pDestination = -1);
    }
}

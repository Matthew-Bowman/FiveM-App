using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveM_EventManager.CFXEventsInterface
{
    internal class CFXEventInterface : IInterfaceCFXEvents
    {
        public void AddEventHandler(ServerEvent pEventName, Action<string> pAction)
        {
            throw new NotImplementedException();
        }

        public void AddingNewEventHandler(ClientEvent pEventName, Action<string> pAction)
        {
            throw new NotImplementedException();
        }

        public void TriggerClientEvent(ClientEvent pEventName, string pData, int pDestination = -1)
        {
            throw new NotImplementedException();
        }

        public void TriggerServerEvent(ServerEvent pEventName, string pData)
        {
            throw new NotImplementedException();
        }
    }
}

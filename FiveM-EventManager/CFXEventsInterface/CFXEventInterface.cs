using System;
using CitizenFX.Core;

namespace FiveM_EventManager.CFXEventsInterface
{
    /// <summary>
    /// Class <c>CFXEventInterface</c>
    /// </summary>
    internal class CFXEventInterface : BaseScript, IInterfaceCFXEvents
    {
        /*************** FIELDS ***************/





        /*************** CONSTRUCTORS ***************/





        /*************** PUBLIC METHODS ***************/
        public void AddEventHandler(ServerEvent pEventName, Action<string> pAction)
        {
            throw new NotImplementedException();
        }

        public void AddEventHandler(ClientEvent pEventName, Action<string> pAction)
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





        /*************** PRIVATE METHODS ***************/
    }
}

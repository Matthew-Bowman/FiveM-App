﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveM_EventManager
{
    internal class EventManager : IHandleEvents, ITriggerEvents
    {
        public void AddPseudoHandler(ServerEvent pEventName, Action<string> pAction)
        {
            throw new NotImplementedException();
        }

        public void AddPseudoHandler(ClientEvent pEventName, Action<string> pAction)
        {
            throw new NotImplementedException();
        }

        public void CompileEvents()
        {
            throw new NotImplementedException();
        }

        public void TriggerEvent(ServerEvent pEventName, string pData)
        {
            throw new NotImplementedException();
        }

        public void TriggerEvent(ClientEvent pEventName, string pData)
        {
            throw new NotImplementedException();
        }

        public void TriggerEvent(ClientEvent pEventName, int pDestination)
        {
            throw new NotImplementedException();
        }
    }
}

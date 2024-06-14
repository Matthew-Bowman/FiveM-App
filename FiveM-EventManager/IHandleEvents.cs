using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveM_EventManager
{
    internal interface IHandleEvents
    {
        void AddPseudoHandler(ServerEvent pEventName, Action<string> pAction);
        void AddPseudoHandler(ClientEvent pEventName, Action<string> pAction);

        void CompileEvents();
    }
}

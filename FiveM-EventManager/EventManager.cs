using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FiveM_EventManager
{
    public class EventManager : IHandleEvents, ITriggerEvents
    {
        /*************** FIELDS ***************/

        // Declare a field to contain the network node the program currently exists on and should behave towards
        private NetworkNode _node;





        /*************** CONSTRUCTORS ***************/

        /// <summary>
        /// Constructor <c>EventManager</c> returns a reference to the created object
        /// </summary>
        /// <param name="pNode">The current network node the program exists on</param>
        public EventManager(NetworkNode pNode)
        {
            _node = pNode;
        }





        /*************** PUBLIC METHODS ***************/
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

        public void TriggerEvent(ClientEvent pEventName, string pData, int pDestination = -1)
        {
            throw new NotImplementedException();
        }





        /*************** PRIVATE METHODS ***************/
    }
}

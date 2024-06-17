using FiveM_EventManager.Exceptions;
using FiveM_EventManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveM_App_EventManager_Tests
{
    public class EventManagerClientHandlerCompilingTests
    {
        /*************** TESTS ***************/

        [Fact]
        public void CompileHandlersTest()
        {
            // Arrange
            IHandleEvents eventHandler = new EventManager(NetworkNode.Client);

            ClientEvent clientEvent = ClientEvent.XUnitTestEvent;
            Action<string> eventAction = new Action<string>(OnTestEvent);

            eventHandler.AddPseudoHandler(clientEvent, eventAction);

            // Act
            Exception exception = Record.Exception(() => eventHandler.CompileEvents());

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void AlreadyCompiledTest()
        {
            // Arrange
            IHandleEvents eventHandler = new EventManager(NetworkNode.Client);

            ClientEvent clientEvent = ClientEvent.XUnitTestEvent;
            Action<string> eventAction = new Action<string>(OnTestEvent);

            eventHandler.AddPseudoHandler(clientEvent, eventAction);

            // Act
            eventHandler.CompileEvents();

            // Assert
            Assert.Throws<HandlersAlreadyCompiledException>(() => eventHandler.CompileEvents());
        }





        /*************** HELPER FUNCTIONS ***************/
        private void OnTestEvent(string pData) { }
    }
}

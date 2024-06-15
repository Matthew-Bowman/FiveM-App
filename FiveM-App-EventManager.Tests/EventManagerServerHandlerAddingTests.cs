using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using FiveM_EventManager;

namespace FiveM_App_EventManager_Tests
{
    public class EventManagerServerHandlerAddingTests
    {
        /*************** TESTS ***************/
        [Fact]
        public void AddServerEventTest()
        {
            // Arrange
            IHandleEvents eventHandler = new EventManager(NetworkNode.Server);

            ServerEvent serverEvent = ServerEvent.XUnitTestEvent;
            Action<string> eventAction = new Action<string>(OnTestEvent);

            // Act
            Exception exception = Record.Exception(() => eventHandler.AddPseudoHandler(serverEvent, eventAction));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void AddClientEventTest()
        {
            // Arrange
            IHandleEvents eventHandler = new EventManager(NetworkNode.Client);

            ClientEvent clientEvent = ClientEvent.XUnitTestEvent;
            Action<string> eventAction = new Action<string>(OnTestEvent);

            // Act
            Exception exception = Record.Exception(() => eventHandler.AddPseudoHandler(clientEvent, eventAction));

            // Assert
            Assert.Null(exception);
        }





        /*************** HELPER METHODS ***************/
        private void OnTestEvent(string pData) { }
    }
}

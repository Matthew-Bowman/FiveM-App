using FiveM_EventManager;
using FiveM_EventManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveM_App_EventManager_Tests
{
    public class EventManagerServerTriggerTests
    {
        /*************** TESTS ***************/
        [Fact]
        public void TriggerServerEventTest()
        {
            // Arrange
            ITriggerEvents eventManager = new EventManager(NetworkNode.Client);

            ServerEvent serverEvent = ServerEvent.XUnitTestEvent;
            string eventData = "{}";

            // Act
            Exception exception = Record.Exception(() => eventManager.TriggerEvent(serverEvent, eventData));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void InvalidTriggerEventTest()
        {
            // Arrange
            ITriggerEvents eventManager = new EventManager(NetworkNode.Client);

            ClientEvent clientEvent = ClientEvent.XUnitTestEvent;
            string eventData = "{}";

            // Act & Assert
            Assert.Throws<IncorrectNetworkNodeException>(() => eventManager.TriggerEvent(clientEvent, eventData));
        }





        /*************** HELPER FUNCTIONS ***************/
    }
}

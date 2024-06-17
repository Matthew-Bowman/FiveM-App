using FiveM_EventManager.Exceptions;
using FiveM_EventManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveM_App_EventManager_Tests
{
    public class EventManagerClientTriggerTests
    {
        /*************** TESTS ***************/
        [Fact]
        public void TriggerServerEventTest()
        {
            // Arrange
            ITriggerEvents eventManager = new EventManager(NetworkNode.Server);

            ClientEvent clientEvent = ClientEvent.XUnitTestEvent;
            string eventData = "{}";

            // Act
            Exception exception = Record.Exception(() => eventManager.TriggerEvent(clientEvent, eventData));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void InvalidTriggerEventTest()
        {
            // Arrange
            ITriggerEvents eventManager = new EventManager(NetworkNode.Server);

            ServerEvent serverEvent = ServerEvent.XUnitTestEvent;
            string eventData = "{}";

            // Act & Assert
            Assert.Throws<IncorrectNetworkNodeException>(() => eventManager.TriggerEvent(serverEvent, eventData));
        }

        [Fact]
        public void InvalidNetworkIDTest()
        {
            // Arrange
            ITriggerEvents eventManager = new EventManager(NetworkNode.Server);

            ClientEvent clientEvent = ClientEvent.XUnitTestEvent;
            string eventData = "{}";

            // Act & Assert
            Assert.Throws<InvalidNetworkIDException>(() => eventManager.TriggerEvent(clientEvent, eventData, -5));
        }

        [Fact]
        public void ValidNetworkIDTest()
        {
            // Arrange
            ITriggerEvents eventManager = new EventManager(NetworkNode.Server);

            ClientEvent clientEvent = ClientEvent.XUnitTestEvent;
            string eventData = "{}";

            // Act
            Exception exception = Record.Exception(() => eventManager.TriggerEvent(clientEvent, eventData, 5));

            // Assert
            Assert.Null(exception);
        }





        /*************** HELPER FUNCTIONS ***************/
    }
}

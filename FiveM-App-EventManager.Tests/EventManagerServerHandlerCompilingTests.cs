using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FiveM_EventManager;
using FiveM_EventManager.Exceptions;
using Xunit;

namespace FiveM_App_EventManager_Tests
{
    public class EventManagerServerHandlerCompilingTests
    {
        /*************** TESTS ***************/

        [Fact]
        public void CompileHandlersTest()
        {
            // Arrange
            IHandleEvents eventHandler = new EventManager(NetworkNode.Server);

            ServerEvent serverEvent = ServerEvent.XUnitTestEvent;
            Action<string> eventAction = new Action<string>(OnTestEvent);

            eventHandler.AddPseudoHandler(serverEvent, eventAction);

            // Act
            Exception exception = Record.Exception(() => eventHandler.CompileEvents());

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void AlreadyCompiledTest()
        {
            // Arrange
            IHandleEvents eventHandler = new EventManager(NetworkNode.Server);

            ServerEvent serverEvent = ServerEvent.XUnitTestEvent;
            Action<string> eventAction = new Action<string>(OnTestEvent);

            eventHandler.AddPseudoHandler(serverEvent, eventAction);

            // Act
            eventHandler.CompileEvents();

            // Assert
            Assert.Throws<HandlersAlreadyCompiledException>(() => eventHandler.CompileEvents());
        }





        /*************** HELPER FUNCTIONS ***************/
        private void OnTestEvent(string pData) { }
    }
}

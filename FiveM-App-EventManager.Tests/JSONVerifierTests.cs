using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FiveM_EventManager;

namespace FiveM_App_EventManager_Tests
{
    public class JSONVerifierTests
    {
        /*************** TESTS ***************/
        [Fact]
        public void VerifySimpleJSON()
        {
            // Arrange
            IVerifyJSON jsonVerifier = new JSONVerifier();

            string jsonData = "{\"key\":\"value\"}";

            // Act
            bool validJSON = jsonVerifier.VerifyJSON(jsonData);

            // Assert
            Assert.True(validJSON);
        }
    }
}

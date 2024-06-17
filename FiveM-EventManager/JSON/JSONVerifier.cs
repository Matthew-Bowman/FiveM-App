using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FiveM-App-EventManager.Tests")]
namespace FiveM_EventManager
{
    internal class JSONVerifier : IVerifyJSON
    {
        /*************** FIELDS ***************/





        /*************** CONSTRUCTORS ***************/





        /*************** PUBLIC METHODS ***************/
        public JSONVerifier() { }
        public bool VerifyJSON(string pData)
        {
            throw new NotImplementedException();
        }





        /*************** PRIVATE METHODS ***************/
    }
}

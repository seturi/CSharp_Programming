using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PrepTest
{
    class Common
    {
        public string GetServer()
        {
            string server;
#if(TEST_ENV)
            server = "TESTSERVER";
#else
            server= = "PRODSERVER";
#endif
            return server;
        }
    }
}

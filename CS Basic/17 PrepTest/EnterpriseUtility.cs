//#define ENTERPRISE_EDITION

#if(!ENTERPRISE_EDITION)
#error This class should be used in ENTERPRISE_EDITION
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 169

namespace _17_PrepTest
{
    class EnterpriseUtility
    {
        #region Fields
        private bool debug;
        private string key;
        #endregion

        #region Properties
        public int Id { get; set; }
        #endregion

        #region Methods
        public void Encrypt() { }
        public void Decrypt() { }

#pragma warning disable
        public void Run()
        {
            // ...

            if(false)
            {
                var b = Step1();
                if(b)
                {
                    Step2();
                }
                else
                {
                    Step3();
                }
            }
#pragma warning restore
        }

        private bool Step1() { return true; }
        private bool Step2() { return true; }
        private bool Step3() { return true; }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfaceTest
{
    class Email : ISendable
    {
        private string email = "admin@csharpstudy.com";
        public void Send(string msg)
        {
            Console.WriteLine($"Email {msg} to {email}");
        }

        public bool ValidateEmail()
        {
            // ...
            return true;
        }
    }

    public class SnailMail : ISendable
    {
        public string Address { get; set; }

        public void Send(string msg)
        {
            Console.WriteLine($"Visit {Address} and deliver note: {msg}");
        }

        public bool CheckAddress()
        {
            // Check ...
            return true;
        }
    }

    public class SMS : ISendable
    {
        public string Phone { get; set; }
        public void Send(string msg)
        {
            Console.WriteLine($"Send message '{msg} to {Phone}");
        }

        public void TestPhoneNumber()
        {
            // Test phoen ...
        }
    }
}

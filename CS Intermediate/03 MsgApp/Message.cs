﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03_MsgApp
{
    abstract class MessageBase
    {
        protected Guid id = Guid.NewGuid();
        public string ToWhom { get; set; }
        public string Message { get; set; }

        public abstract void Send();
        //{
        //    Console.WriteLine($"Send Message to {ToWhom}:");
        //    Console.WriteLine($"{Message}");
        //}

        public void DebugMessageInfo()
        {
            Debug.WriteLine("Message Id: {0}", id);
            Debug.WriteLine("To: {0}", ToWhom);
            Debug.WriteLine("Message: {0}", Message);
        }
    }

    sealed class EmailMessage : MessageBase
    {
        public string Email { get; set; }

        public EmailMessage(string email)
        {
            Email = email;
        }
        
        public override void Send()
        {
            MailMessage msg = new MailMessage("sender@live.com", this.Email, "제목", this.Message);
            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("sender@live.com", "password");
            smtp.Send(msg);
        }
    }

    //class CompanyEmail : EmailMessage
    //{
    //    public CompanyEmail(string email) : base(email)
    //    {
    //    }
    //}

    class SMSMessage : MessageBase
    {
        public string PhoneNumber { get; set; }

        public override void Send()
        {
            //TwilioClient.Init(accountSid, authToken);
            //var message = MessageResource.Create(
            //    body: this.Message,
            //    from: new Twilio.Types.PhoneNumber("+15017122661"),
            //    to: new Twilio.Types.PhoneNumber("this.PhoneNumber"
            //    );
        }
    }

    //
}

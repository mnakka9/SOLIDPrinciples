using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public class DIP
    {
        /*
         High level modules should not depend on low level modules.
         Both high level and low level modules should depend on
         abstractions

         Abstraction should not be dependent on details.
         Details should be depend on abstractions.

         */

        public void Main()
        {
            Console.WriteLine("DIP:");
            var notifier = new SMSNotifier();
            var notification = new Notification(notifier);
            notification.Notify();
        }
    }

    public class Email
    {
        public void SendEmail()
        {
            // sends an email
        }
    }

    public class NotificationNDIP
    {
        private Email email = null;
        public NotificationNDIP()
        {
            email = new Email();
        }

        public void Notify()
        {
            email.SendEmail();
        }
    }

    public interface INotifier
    {
        void Send();
    }

    public class EmailNotifier : INotifier
    {
        public void Send()
        {
            // send email
            Console.WriteLine("Email sent");
        }
    }

    public class SMSNotifier : INotifier
    {
        public void Send()
        {
            // send sms
            Console.WriteLine("SMS sent");
        }
    }



    public class Notification
    {
        private INotifier notifier = null;
        public Notification(INotifier iNotifier)
        {
            notifier = iNotifier;
        }

        public void Notify()
        {
            notifier.Send();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    //Abstraction 
    public interface IMessageSender
    {
        void Send();
    }

    public abstract class SendingData
    {
        public string message { get; set; }

        public SendingData(string message)
        {
            this.message = message; 
        }
    }
    
    //Low level module 
    public class SMS : SendingData, IMessageSender
    {
        public SMS(string message) : base(message)
        {
        }
        public void Send()
        {
            // Logic to send SMS
            Console.WriteLine("Sending SMS: " + message);
        }
    }

    public class Email : SendingData, IMessageSender
    {
        public Email(string message) : base(message)
        {
        }
        public void Send()
        {
            // Logic to send email
            Console.WriteLine("Sending Email: " + message);
        }
    }

    // High-level module (App) depends on IMessageSender
    public class App
    {
        private IMessageSender messageSender;

        public App(IMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }

        public void NotifyUser(string message)
        {
            // Use the messageSender to send a notification
            messageSender.Send();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Sms and Email classes
            IMessageSender smsSender = new SMS("Hello from SMS!");
            IMessageSender emailSender = new Email("Hello from Email!");

            // Create App instances with different message senders
            App smsApp = new App(smsSender);
            App emailApp = new App(emailSender);

            // Use the App instances to send notifications
            smsApp.NotifyUser("Hello from SMS!");
            emailApp.NotifyUser("Hello from Email!");
        }
    }
}

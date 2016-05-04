using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Text;
using MIRServer.Models;

namespace MIRServer.Infrastructure
{
    public static class Email
    {
        public static void emailIncident(Incident incident)
        {
            string emailBody = "Incident: " + incident.Category.ToUpper() + "\n" +
                               "Date: " + incident.IncidentDate + "\n" +
                               "Time: " + incident.IncidentTime + "\n" +
                               "Location: " + incident.Location + "\n" +
                               "Details: " + incident.Details + "\n";

            SendEmail("stephen@moonsolutions.co.uk", "donotreply@mirserver.com", "MIR Server", incident.Category, emailBody);
        }

        private static void SendAsync(SendGrid.SendGridMessage message)
        {
            string apikey = "apikey";
            var transportWeb = new SendGrid.Web(apikey);

            try
            {
                transportWeb.DeliverAsync(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void SendEmail(string to, string from, string fromName, string subject, string text)
        {
            var myMessage = new SendGrid.SendGridMessage();
            myMessage.AddTo(to);
            myMessage.From = new MailAddress(from, fromName);
            myMessage.Subject = subject;
            myMessage.Text = text;

            SendAsync(myMessage);
        }
    }
}
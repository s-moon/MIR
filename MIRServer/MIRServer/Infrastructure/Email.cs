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

            SendEmail("donotreply@mirserver.com", "stephen@moonsolutions.co.uk", incident.Category, emailBody);
        }

        public static void SendEmail(string from, string to, string subject, string body)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "auth.smtp.1and1.co.uk";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("test@moonsolutions.co.uk", "pwd");

            MailMessage mm = new MailMessage(from, to, subject, body);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Text;

namespace MIRServer.Infrastructure
{
    public static class Email
    {
        public static void sendTheEmail()
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "auth.smtp.1and1.co.uk";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("test@moonsolutions.co.uk", "pwd");

            MailMessage mm = new MailMessage("donotreply@mirserver.com", "stephen@moonsolutions.co.uk", "test", "test");
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }
    }
}
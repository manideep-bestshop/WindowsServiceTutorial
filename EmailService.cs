using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceTutorials
{
    internal class EmailService
    {
        internal static void SendEmail(string message)
        {
            string fromMail = "nmanideep1015@gmail.com";
            string fromPassword = "iwzfhxfrmjahomcu";

            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(fromMail);
            msg.Subject = message;
            msg.To.Add(new MailAddress("nmanideep1015@gmail.com"));
            msg.Body = "Service Related";
            msg.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(msg);
        }

    }
}

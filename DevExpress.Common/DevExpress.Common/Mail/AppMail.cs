using System;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace PSCLic.Mail
{
    public class AppMail
    {
        private NetworkCredential login;
        private SmtpClient client;

        /// <summary>
        /// Init mail server
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public AppMail(string username, string password)
        {
            login = new NetworkCredential(username, password);
        }  

        /// <summary>
        /// Init SMTP Server
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="ssl"></param>
        public void InitSmtp(string host, int port, bool ssl)
        {
            client = new SmtpClient(host);
            client.Port = port;
            client.EnableSsl = ssl;
            client.Credentials = login;
        }

        /// <summary>
        /// Init MailServer
        /// </summary>
        /// <param name="from"></param>
        /// <param name="displayName"></param>
        /// <param name="to"></param>
        /// <param name="cc"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="html"></param>
        /// <returns></returns>
        private static MailMessage MailMessageServer(string from, string displayName, string to, string cc, string subject, string body, bool html)
        {
            MailMessage msg = new MailMessage { From = new MailAddress(from, displayName, Encoding.UTF8) };
            msg.To.Add(new MailAddress(to));
            if (!string.IsNullOrEmpty(cc))
                msg.To.Add(new MailAddress(cc));
            msg.Subject = subject;
            msg.Body = body;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = html;
            msg.Headers.Add("Mail", "App Mail Server");
            msg.Priority = MailPriority.High;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            return msg;
        }

        /// <summary>
        /// Send mail
        /// </summary>
        /// <param name="from"></param>
        /// <param name="displayName"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="html"></param>
        /// <param name="asyn"></param>
        /// <returns></returns>
        public bool Send(string from, string displayName, string to, string subject, string body, bool html, bool asyn)
        {
            try
            {
                MailMessage msg = MailMessageServer(from, displayName, to, null, subject, body, html);
                if (asyn)
                    client.SendAsync(msg, "App Mail Server");
                else
                    client.Send(msg);
            }
            catch { return false; }
            return true;
        }

        /// <summary>
        /// Send mail, CC
        /// </summary>
        /// <param name="from"></param>
        /// <param name="displayName"></param>
        /// <param name="to"></param>
        /// <param name="cc"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="html"></param>
        /// <param name="asyn"></param>
        /// <returns></returns>
        public bool Send(string from, string displayName, string to, string cc ,string subject, string body, bool html, bool asyn)
        {
            try
            {
                MailMessage msg = MailMessageServer(from, displayName, to, cc, subject, body, html);
                if (asyn)
                    client.SendAsync(msg, "App Mail Server");
                else
                    client.Send(msg);
            }
            catch { return false; }
            return true;
        }
    }
}

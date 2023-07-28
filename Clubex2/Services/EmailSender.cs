using Clubex2.Data;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;
using Clubex2.Models;
using Clubex2.Interfaces;

namespace Clubex2.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly ApplicationDbContext _context;
        public EmailSender(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> SendEmailAsync(EmailRequest request, List<string> cc = null)
        {
            var SMTP = await _context.SmtpSettings.FirstOrDefaultAsync();

            var result = string.Empty;

            try
            {
                using SmtpClient client = new();

                ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

                MailMessage mail = new MailMessage(SMTP.HostIP, request.RecieverEmailAddress);
                client.Port = int.Parse(SMTP.PortNumber);
                client.Host = SMTP.Host;
                client.Credentials = new NetworkCredential(SMTP.UserName, SMTP.Password);
                client.EnableSsl = true;
                mail.From = new MailAddress(SMTP.HostIP, Constants.AppName);
                mail.Subject = request.Subject;
                mail.IsBodyHtml = true;

                if (cc != null && cc.Count > 0)
                {
                    foreach (var item in cc)
                    {
                        if (item != null)
                        {
                            mail.CC.Add(item);
                        }
                    }
                }

                mail.To.Add(new MailAddress(request.RecieverEmailAddress));
                mail.Sender = new MailAddress(SMTP.HostIP, Constants.AppName);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                var bodyMessage = request.Body;

                mail.Body = bodyMessage;

                client.Send(mail);

                result = "Success";

            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }

            return result;
        }

        public Task<string> SendEmailAsync(string email, string code, string message)
        {
            throw new NotImplementedException();
        }
    }
}

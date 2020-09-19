using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.Infrustructure
{
    public class Mailler
    {
        public async Task SendMailAsync(string serviceEmail, string serviceEmailPassword, string subject, string body)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Fiddle mailbox", serviceEmail));
            emailMessage.To.Add(new MailboxAddress("", "hello@fiddle.digital"));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = body
            };

            try
            {
                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync("smtp.ukr.net", 465);
                    await client.AuthenticateAsync(serviceEmail, serviceEmailPassword);
                    await client.SendAsync(emailMessage);

                    await client.DisconnectAsync(true);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
    }
}

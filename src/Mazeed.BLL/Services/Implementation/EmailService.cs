using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.BLL.Helpers;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace Mazeed.BLL.Services.Implementation
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _emailSettings;

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task<string> GetEmailTemplateAsync(string templateName, Dictionary<string, string> placeholders)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "EmailTemplates", $"{templateName}.html");

            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Email template '{templateName}' not found.");

            string body = await File.ReadAllTextAsync(filePath);

            foreach (var item in placeholders)
            {
                body = body.Replace($"{{{{{item.Key}}}}}", item.Value);
            }

            return body;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string htmlBody)
        {
            var message = new MailMessage
            {
                From = new MailAddress(_emailSettings.SenderEmail, _emailSettings.SenderName),
                Subject = subject,
                Body = htmlBody,
                IsBodyHtml = true
            };

            message.To.Add(new MailAddress(toEmail));

            using var smtpClient = new SmtpClient(_emailSettings.Host, _emailSettings.Port)
            {
                Credentials = new NetworkCredential(_emailSettings.Username, _emailSettings.Password),
                EnableSsl = _emailSettings.EnableSsl
            };

            await smtpClient.SendMailAsync(message);
        }

        public async Task ProcessContactFormAsync(ContactVM model)
        {
            var adminPlaceholders = new Dictionary<string, string>
            {
                { "Name", model.Name },
                { "Email", model.Email },
                { "Subject", model.Subject },
                { "Message", model.Message }
            };

            var adminBody = await GetEmailTemplateAsync("ContactAdmin", adminPlaceholders);
            var adminSubject = $"[New Contact] {model.Subject}";

            var userPlaceholders = new Dictionary<string, string>
            {
                { "Name", model.Name },
                { "Subject", model.Subject }
            };

            var userBody = await GetEmailTemplateAsync("ContactUser", userPlaceholders);
            var userSubject = "Thank you for reaching out - We have received your message";

            await SendEmailAsync(_emailSettings.AdminEmail, adminSubject, adminBody);
            await SendEmailAsync(model.Email, userSubject, userBody);
        }
    }
}

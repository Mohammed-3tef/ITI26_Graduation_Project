using Mazeed.BLL.ViewModels;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IEmailService
    {
        Task<string> GetEmailTemplateAsync(string templateName, Dictionary<string, string> placeholders);
        Task SendEmailAsync(string toEmail, string subject, string htmlBody);
        Task ProcessContactFormAsync(ContactVM model);
    }
}

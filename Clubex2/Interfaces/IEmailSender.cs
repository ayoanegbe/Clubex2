using Clubex2.Models;

namespace Clubex2.Interfaces
{
    public interface IEmailSender
    {
        Task<string> SendEmailAsync(EmailRequest request, List<string> cc = null);
        Task<string> SendEmailAsync(string email, string code, string message);
    }
}

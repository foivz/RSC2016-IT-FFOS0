using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);

        Task<bool> SendTwoFactorAuthenticationCodeAsync(object userEmail);
    }
}
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);

        Task<bool> SendTwoFactorAuthenticationCodeAsync(object userPhoneNumber);
    }
}
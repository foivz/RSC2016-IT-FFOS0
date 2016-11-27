using System.ComponentModel.DataAnnotations;

namespace HackathonVZ.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

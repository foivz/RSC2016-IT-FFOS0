using Models.Models.Lookup;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HackathonVZ.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
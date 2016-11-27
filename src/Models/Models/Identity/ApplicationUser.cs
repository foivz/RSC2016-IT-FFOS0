using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Models.Models.Lookup;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HackathonVZ.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public int CountryId { get; set; }

        [DefaultValue(false)]
        public bool IsArchived { get; set; }
    }
}
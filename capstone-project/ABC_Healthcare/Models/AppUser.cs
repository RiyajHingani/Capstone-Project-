using Microsoft.AspNetCore.Identity;

namespace HealthCare.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; }
    }
}

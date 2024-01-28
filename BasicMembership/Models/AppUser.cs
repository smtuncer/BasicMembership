using Microsoft.AspNetCore.Identity;

namespace BasicMembership.Models
{
    public class AppUser : IdentityUser
    {
        public string NameSurname { get; set; }
    }
}

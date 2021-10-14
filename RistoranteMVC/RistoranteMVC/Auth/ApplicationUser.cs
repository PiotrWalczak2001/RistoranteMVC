using Microsoft.AspNetCore.Identity;

namespace RistoranteMVC.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using VMS.Server.Models;

namespace VMS.Server.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public Role Role { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace FreelanceMarketplace.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Country { get; set; }
        public string ProfileImage { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

    }
}

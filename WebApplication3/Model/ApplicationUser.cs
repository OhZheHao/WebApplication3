using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WebApplication3.Model
{
    public class ApplicationUser: IdentityUser
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        public string? NRIC { get; set; }
        [Required]
        public string CaptchaToken { get; set; }
        public string? DOB { get; internal set; }
        public string? Resume { get; internal set; }
        public string? WhoAmI { get; internal set; }
    }
}

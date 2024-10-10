using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ksiegarniaAplikacja.Models {
    public class AppUser : IdentityUser {
        public string Password { get; set; }
        public string Role { get; set; }
        public Cart Cart { get; set; }
	}
}

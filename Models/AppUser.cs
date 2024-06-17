using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Api_React_Fast_Food_Online.Server.Models
{
    public class AppUser : IdentityUser
    {
        [StringLength(100)]
        [MaxLength(100)]
        [Required]
        public string? Name { get; set; }
        public string? Address { get; set; }

    }
}
using System.ComponentModel.DataAnnotations;

namespace Api_React_Fast_Food_Online.Server.Models
{
    public class Roles
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string RoleName { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public Employees Employee { get; set; }  // One-to-one relationship
    }
}

using System.ComponentModel.DataAnnotations;

namespace Api_React_Fast_Food_Online.Server.DTOs.RolesDTO
{
    public class CreateRolesRequersDto
    {
        [Required, MaxLength(50)]
        public string RoleName { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
    }
}

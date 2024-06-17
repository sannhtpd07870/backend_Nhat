using System.ComponentModel.DataAnnotations;

namespace Api_React_Fast_Food_Online.Server.DTOs.RolesDTO
{
    public class RoleDto
    {
        public int Id { get; set; }

        public string RoleName { get; set; }

        public string Description { get; set; }
    }
}

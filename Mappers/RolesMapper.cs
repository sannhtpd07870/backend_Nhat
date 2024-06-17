using Api_React_Fast_Food_Online.Server.DTOs.RolesDTO;
using Api_React_Fast_Food_Online.Server.Models;

namespace Api_React_Fast_Food_Online.Server.Mappers
{
    public static class RolesMapper
    {
        public static RoleDto ToRoleDto(this Roles roleModel)
        {
            return new RoleDto
            {
                Id = roleModel.Id,
                RoleName = roleModel.RoleName,
                Description = roleModel.Description
            };
        }
        public static Roles ToRoleFromCreateDto(this CreateRolesRequersDto roleDto)
        {
            return new Roles
            {
                RoleName = roleDto.RoleName,
                Description = roleDto.Description
            };
        }
    }
}

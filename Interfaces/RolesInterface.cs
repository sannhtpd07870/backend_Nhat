using Api_React_Fast_Food_Online.Server.DTOs.RolesDTO;
using Api_React_Fast_Food_Online.Server.Models;

namespace Api_React_Fast_Food_Online.Server.Interfaces
{
    public interface RolesInterface
    {
        Task<List<Roles>> GetAllAsync();
        Task<Roles?> GetByIdAsync(int id);
        Task<Roles> CreateAsync(Roles roleModel);
        Task<Roles?> UpdateAsync(int id, UpdateRolesRequersDto roleDto);
        Task<Roles?> DeleteAsync(int id);
        Task<bool> RoleExists(int id);
    }
}

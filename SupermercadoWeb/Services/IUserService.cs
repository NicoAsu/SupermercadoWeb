using SupermercadoWeb.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupermercadoWeb.Services
{
    public interface IUserService
    {
        Task<bool> DeleteUser(string id);
        Task<IEnumerable<AspNetUser>> GetAllUser();
        Task<IEnumerable<AspNetRole>> GetAllRoles();
        Task<AspNetUser> GetUser(int id);
        Task<bool> UpdateUser(AspNetUser user);
    }
}
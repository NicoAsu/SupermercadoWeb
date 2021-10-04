using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SupermercadoWeb.Models;
namespace SupermercadoWeb.Services
{
    public class UserService : IUserService
    {
        private readonly tyrone09876543_ProyectoFinalDBContext _context;
        public UserService(tyrone09876543_ProyectoFinalDBContext context)
        {
            _context = context;
        }
        public async Task<bool> DeleteUser(string id)
        {
            var user = await _context.AspNetUsers.FindAsync(id);

            _context.AspNetUsers.Remove(user);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<AspNetUser> GetUser(int id)
        {
            return await _context.AspNetUsers.FindAsync(id);
        }

        public async Task<IEnumerable<AspNetUser>> GetAllUser()
        {
            return await _context.AspNetUsers.ToListAsync();
        }

        public async Task<bool> UpdateUser(AspNetUser user)
        {
            _context.Entry(user).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<AspNetRole>> GetAllRoles()
        {
            return await _context.AspNetRoles.ToListAsync();
        }

    }
}


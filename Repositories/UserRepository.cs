using Microsoft.EntityFrameworkCore;
using GivingGardenBE.Data;
using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;

namespace GivingGardenBE.Repositories
{
    public class UserRepository : IUserRepository

    {
        private readonly GivingGardenBEDbContext _context;

        public UserRepository(GivingGardenBEDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUserAsync()
        {
            return await _context.Users.ToListAsync();
        }
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> CreateUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUserAsync(int id, User user)
        {
            var existingUser = await _context.Users.FindAsync(id);
            if (existingUser == null)
            {
                return null;
            }
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            existingUser.Image = user.Image;
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> DeleteUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return null;
            }
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}

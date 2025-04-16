using GivingGardenBE.Models;

namespace GivingGardenBE.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetUserAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> CreateUserAsync(User user);
        Task<User> UpdateUserAsync(int id, User user);
        Task<User> DeleteUserAsync(int id);
    }
}

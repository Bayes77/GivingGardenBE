using GivingGardenBE.Models;

namespace GivingGardenBE.Interfaces
{
    public interface IUserServices
    {
        // responsible for processing business logic
        // will call the repository layer to do the actual CRUD operations
        Task<List<User>> GetUserAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> CreateUserAsync(User user);
        Task<User> UpdateUserAsync(int id, User user);
        Task<User> DeleteUserAsync(int id);
    }
}

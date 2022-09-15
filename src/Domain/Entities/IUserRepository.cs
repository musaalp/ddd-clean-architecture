using Domain.ValueObjects;

namespace Domain.Entities
{
    public interface IUserRepository
    {
        Task<User> GetUser(UserId userId);
        Task<UserId> Add(User user);
        Task Delete(UserId userId);
        Task Update(User user);
    }
}

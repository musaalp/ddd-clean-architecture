using Domain.Entities;
using Domain.ValueObjects;

namespace Application.UseCases.GetUser
{
    public sealed class GetUserUseCase : IGetUserUseCase
    {
        public readonly IUserRepository _userRepository;

        public GetUserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Execute(Guid userId)
        {
            return await _userRepository.GetUser(new UserId(userId));
        }
    }
}

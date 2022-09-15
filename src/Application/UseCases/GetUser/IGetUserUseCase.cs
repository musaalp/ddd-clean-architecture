using Domain.Entities;

namespace Application.UseCases.GetUser
{
    public interface IGetUserUseCase
    {
        Task<User> Execute(Guid userId);
    }
}

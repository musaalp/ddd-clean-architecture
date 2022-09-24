using Domain.Entities;

namespace Application.UseCases.GetUser
{
    public sealed class GetUserValidationUseCase : IGetUserUseCase
    {
        public readonly IGetUserUseCase _useCase;

        public GetUserValidationUseCase(IGetUserUseCase useCase)
        {
            _useCase = useCase;
        }

        public async Task<User> Execute(Guid userId)
        {
            return await _useCase.Execute(userId);
        }
    }
}

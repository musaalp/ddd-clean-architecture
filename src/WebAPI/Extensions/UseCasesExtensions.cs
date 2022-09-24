using Application.UseCases.GetUser;

namespace WebAPI.Extensions
{
    public static class UseCasesExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IGetUserUseCase, GetUserUseCase>();
            services.Decorate<IGetUserUseCase, GetUserValidationUseCase>();

            return services;
        }
    }
}

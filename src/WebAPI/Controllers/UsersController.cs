using Application.UseCases.GetUser;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet("{userId}")]
        public async Task<IActionResult> Get([FromRoute] Guid userId, [FromServices] IGetUserUseCase useCase)
        {
            var user = await useCase.Execute(userId);

            return Ok(user);
        }
    }
}
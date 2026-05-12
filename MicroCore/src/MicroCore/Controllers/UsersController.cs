using Application.Features.Users;
using Microsoft.AspNetCore.Mvc;

namespace MicroCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly CreateUserCommandHandler _handler;
        public UsersController(CreateUserCommandHandler handler)
        {
            _handler = handler;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserCommand req)
        {
            var id = await _handler.Handle(req);
            return Ok(id);
        }
    }
}

using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users
{
    public class CreateUserCommandHandler
    {
        private readonly IUserRepository _userRepository;
        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<Guid> Handle(CreateUserCommand com)
        {
            var user = new User(com.Email,com.Name);
            await _userRepository.GuardarUser(user);
            return user.Id;
        }
    }
}

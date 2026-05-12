using Domain.Entities;
namespace Application.Interfaces
{
    public interface IUserRepository
    {
        Task GuardarUser(User user);
    }
}

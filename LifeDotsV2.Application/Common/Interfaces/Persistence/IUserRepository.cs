using LifeDotsV2.Domain.Entities;

namespace LifeDotsV2.Application.Common.Interfaces.Persistence
{
    public interface IUserRepository
    {
        User? GerUserByEmail(string email);
        void Add(User user);
    }
}

using LifeDotsV2.Domain.Entities;

namespace LifeDotsV2.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}

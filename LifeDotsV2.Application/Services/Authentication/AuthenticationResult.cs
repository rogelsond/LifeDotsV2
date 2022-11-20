using LifeDotsV2.Domain.Entities;

namespace LifeDotsV2.Application.Services.Authentication
{
    public record AuthenticationResult(
        User User,
        string Token);
}

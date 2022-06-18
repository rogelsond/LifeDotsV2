using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeDotsV2.Application.Services.Authentication
{
    internal interface IAuthenticationService
    {
        AuthenticationResponse Login(LoginRequest request);
        AuthenticationResponse Register(RegisterRequest request);
    }
}

﻿using LifeDotsV2.Application.Services.Authentication;
using LifeDotsV2.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace LifeDotsV2.API.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var authResult = _authenticationService.Register(
                request.FirstName,
                request.LastName,
                request.Email,
                request.Password);

            var response = new AuthenticationResponse(
                authResult.User.Id,
                authResult.User.Email,
                authResult.User.FirstName,
                authResult.User.LastName,
                authResult.Token);

            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authenticationService.Login(
                request.Email,
                request.Password);

            var response = new AuthenticationResponse(
                authResult.User.Id,
                authResult.User.Email,
                authResult.User.FirstName,
                authResult.User.LastName,
                authResult.Token);

            return Ok(response);
        }
    }
}

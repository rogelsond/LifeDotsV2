﻿using LifeDotsV2.Application.Common.Interfaces.Authentication;
using LifeDotsV2.Application.Common.Interfaces.Services;
using LifeDotsV2.Infrastructure.Authentication;
using LifeDotsV2.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using LifeDotsV2.Application.Common.Interfaces.Persistence;
using LifeDotsV2.Infrastructure.Persistence;

namespace LifeDotsV2.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
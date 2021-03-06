﻿using Microsoft.Extensions.DependencyInjection;
using Devon4Net.Business.Common.UserManagement.Service;
using Devon4Net.Infrastructure.JWT.Configuration;
using Devon4Net.Business.Common.PrestationManagement.Service;
using Devon4Net.Business.Common.NoteManagement.Service;
using Devon4Net.Business.Common.ClientManagement.Service;

namespace Devon4Net.Business.Common.Configuration
{
    public static class BusinessCommonConfiguration
    {
        /// <summary>
        /// Put the service layer DI declaration her
        /// PE from MTS: services.AddTransient<IDishService, DishService>();
        /// </summary>
        /// <param name="services"></param>
        public static void AddBusinessCommonDependencyInjectionService(this IServiceCollection services)
        {
            services.AddTransient<ILoginService, LoginService>();
            services.AddTransient<IPrestationService, PrestationService>(); 
            services.AddTransient<INoteService, NoteService>();
            services.AddTransient<IClientService, ClientService>();
        }

        /// <summary>
        /// Put JWT policy here
        /// PE from MTS: services.ConfigureJwtAddPolicy("MTSWaiterPolicy", "role", "waiter");
        /// </summary>
        /// <param name="services"></param>
        public static void AddBusinessCommonJwtPolicy(this IServiceCollection services)
        {

        }
    }
}

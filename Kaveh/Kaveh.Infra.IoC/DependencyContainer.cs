using Kaveh.Domain.Interfaces;
using Kaveh.Infra.Data.Interfaces;
using Kaveh.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Kaveh.Infra.Data.Context;

namespace Kaveh.Infra.IoC
{
    class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //infra.Data layer
            services.AddTransient(typeof(IGenericRepo<>), typeof(GenericRepo<>));
            services.AddSingleton<IKavehDbContext, KavehDbContext>();
        }
    }
}

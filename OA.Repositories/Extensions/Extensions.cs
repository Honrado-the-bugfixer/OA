using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repositories.Extensions
{
    public static class Extensions
    {
        public static void AddRepositoryLayer(this IServiceCollection services)
        {
            services.AddSingleton<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}

using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Norwich.Newport;


namespace R5T.Norwich.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddJsonFileSerializer(this IServiceCollection services)
        {
            services.AddSingleton<IJsonFileSerializer, NewtonsoftJsonFileSerializer>();

            return services;
        }
    }
}

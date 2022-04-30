using EntityFramework.Config;

namespace EntityFramework.Extension
{
    public static class DependencyInjecction
    {
        public static IServiceCollection AddConnectionGlobal(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConnectionDataBase>(configuration.GetSection("ConnectionStrings"));
            return services;
        }
    }
}

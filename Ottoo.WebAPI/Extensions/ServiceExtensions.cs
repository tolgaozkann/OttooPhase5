using Microsoft.EntityFrameworkCore;
using Ottoo.Repositories.EFCore;

namespace Ottoo.WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration) => services.AddDbContext<RepositoryContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("OttooDatabase")));
    }
}

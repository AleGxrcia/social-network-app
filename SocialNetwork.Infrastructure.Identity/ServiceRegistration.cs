using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Infrastructure.Identity.Contexts;
using SocialNetwork.Infrastructure.Identity.Entities;

namespace SocialNetwork.Infrastructure.Identity
{
    public static class ServiceRegistration
    {
        public static void AddIdentityInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            #region "Context configurations"
            if (config.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<IdentityContext>(opt => opt.UseInMemoryDatabase("IdentityDb"));
            }
            else
            {
                var connectionString = config.GetConnectionString("IdentityConnection");
                services.AddDbContext<IdentityContext>(options =>
                                            options.UseSqlServer(connectionString,
                                            m => m.MigrationsAssembly(typeof(IdentityContext).Assembly.FullName)));
            }
            #endregion

            #region Identity
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<IdentityContext>().AddDefaultTokenProviders();

            services.AddAuthentication();
            #endregion
        }
    }
}

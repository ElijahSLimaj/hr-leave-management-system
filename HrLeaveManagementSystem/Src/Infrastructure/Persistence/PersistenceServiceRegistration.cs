using HrLeaveManagementSystem.Src.Infrastructure.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HrLeaveManagementSystem.Src.Infrastructure.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HrDatabaseContext>(options => {
            options.UseSqlServer(configuration.GetConnectionString("HrDatabaseConfigurationString"));
         });
        return services;
    }
}

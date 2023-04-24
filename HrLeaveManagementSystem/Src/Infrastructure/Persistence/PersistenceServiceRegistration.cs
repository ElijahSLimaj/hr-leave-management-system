using HrLeaveManagementSystem.Src.Core.Application.Contracts.Persistence;
using HrLeaveManagementSystem.Src.Infrastructure.Persistence.DatabaseContext;
using HrLeaveManagementSystem.Src.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HrLeaveManagementSystem.Src.Infrastructure.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HrDatabaseContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("HrDatabaseConfigurationString"));
        });

        // The first iOC approach is done differently because of the fact that
        // IGenericRepository takes in a generic type
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
        services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
        services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();

        return services;
    }
}

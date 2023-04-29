using HR.LeaveManagement.Infrastructure.EmailService;
using HrLeaveManagementSystem.Src.Core.Application.Contracts.Email;
using HrLeaveManagementSystem.Src.Core.Application.Contracts.Logging;
using HrLeaveManagementSystem.Src.Core.Application.Models.Email;
using HrLeaveManagementSystem.Src.Infrastructure.Logging;

namespace HrLeaveManagementSystem.Src.Infrastructure.Persistence;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
        services.AddTransient<IEmailSender, EmailSender>();
        services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

        return services;
    }
}

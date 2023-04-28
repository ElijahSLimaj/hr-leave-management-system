using HrLeaveManagementSystem.Src.Core.Application.Models.Email;

namespace HrLeaveManagementSystem.Src.Core.Application.Contracts.Email;

public interface IEmailSender
{
    Task<bool> SendEmail(EmailMessage email);
}

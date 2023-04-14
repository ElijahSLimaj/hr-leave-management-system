using MediatR;

namespace HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Commands.CreateLeaveType;

public class CreateLeaveTypeCommand : IRequest<int>
{
    public string Name {get; set;} = string.Empty;
    public string DefaultDays { get; set; } = string.Empty;
}

using MediatR;

namespace HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Queries.GetAllLeaveTypes;

public record GetAllLeaveTypesQuery : IRequest<List<LeaveTypeDto>>;
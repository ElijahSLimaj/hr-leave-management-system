using HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;
using MediatR;

public record GetLeaveTypeDetailsQuery(int Id) : IRequest<LeaveTypeDetailsDto>;

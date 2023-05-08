using AutoMapper;
using HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Commands.CreateLeaveType;
using HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Commands.DeleteLeaveType;
using HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Commands.UpdateLeaveType;
using HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;
using HrLeaveManagementSystem.Src.Core.Domain;

namespace HrLeaveManagementSystem.Src.Core.Application.MappingProfiles;

public class LeaveTypeProfile : Profile
{
    public LeaveTypeProfile()
    {
        CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
        CreateMap<LeaveType, LeaveTypeDetailsDto>();
        CreateMap<UpdateLeaveTypeCommand, LeaveType>();
        CreateMap<CreateLeaveTypeCommand, LeaveType>();
        CreateMap<DeleteLeaveTypeCommand, LeaveType>();
    }
}

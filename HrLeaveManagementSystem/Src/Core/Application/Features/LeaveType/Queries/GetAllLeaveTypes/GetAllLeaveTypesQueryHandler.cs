using AutoMapper;
using MediatR;

namespace HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Queries.GetAllLeaveTypes;

public class GetAllLeaveTypesQueryHandler : IRequestHandler<GetAllLeaveTypesQuery, List<LeaveTypeDto>>
{

    private IMapper _mapper;
    private ILeaveTypeRepository _leaveTypeRepository;

    public GetAllLeaveTypesQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        _mapper = mapper;
        _leaveTypeRepository = leaveTypeRepository;
    }
    public async Task<List<LeaveTypeDto>> Handle(GetAllLeaveTypesQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var leaveTypes = await _leaveTypeRepository.GetAsync();

        // Convert data objects to DTO
        var data = _mapper.Map<List<LeaveTypeDto>>(leaveTypes);

        // Return list of DTO objects
        return data;
    }
}

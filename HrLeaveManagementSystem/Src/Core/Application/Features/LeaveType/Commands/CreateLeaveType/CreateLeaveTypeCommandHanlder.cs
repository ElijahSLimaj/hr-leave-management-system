using AutoMapper;
using MediatR;

namespace HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Commands.CreateLeaveType;

public class CreateLeaveTypeCommandHanlder : IRequestHandler<CreateLeaveTypeCommand, int>
{
    public IMapper _mapper;
    public ILeaveTypeRepository _leaveTypeRepository;

    public CreateLeaveTypeCommandHanlder(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        _mapper = mapper;
        _leaveTypeRepository = leaveTypeRepository;
    }
    public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming data
        // Convert to domain entity object
        var leaveTypeToCreate =  _mapper.Map<Domain.LeaveType>(request);
        // Add to database
        await _leaveTypeRepository.CreateAsync(leaveTypeToCreate);
        // return record id
        return leaveTypeToCreate.Id;
    }
}

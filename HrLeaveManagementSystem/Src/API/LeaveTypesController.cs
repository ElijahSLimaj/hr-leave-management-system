using HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Commands.CreateLeaveType;
using HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Commands.DeleteLeaveType;
using HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Commands.UpdateLeaveType;
using HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class LeaveTypesController : ControllerBase
{
    private readonly IMediator _mediator;
    public LeaveTypesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<List<LeaveTypeDto>> Get()
    {
        var leaveTypes = await _mediator.Send(new GetAllLeaveTypesQuery());
        return leaveTypes;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<LeaveTypeDetailsDto>> Get(int id)
    {
        var leaveType = await _mediator.Send(new GetLeaveTypeDetailsQuery(id));
        return Ok(leaveType);
    }

    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Post(CreateLeaveTypeCommand createLeaveType)
    {
        var response = await _mediator.Send(createLeaveType);
        return CreatedAtAction(nameof(Get), new { Id = response });
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Put(UpdateLeaveTypeCommand leaveType)
    {
        await _mediator.Send(leaveType);
        return NoContent();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Delete(int id)
    {
        var command = new DeleteLeaveTypeCommand{Id = id};

        await _mediator.Send(command);

        return NoContent();
    }
}

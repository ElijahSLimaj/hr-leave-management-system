namespace HrLeaveManagementSystem.Src.Core.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;

public class LeaveTypeDetailsDto
{
    public int Id {get; set;}
    public string name {get; set;} = string.Empty;
    public int DefaultDays {get; set;}
    public DateTime? DateCreated;
    public DateTime? DateModified;
}

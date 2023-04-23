using HrLeaveManagementSystem.Src.Core.Domain.Common;

namespace HrLeaveManagementSystem.Src.Core.Domain;

public class LeaveRequest : BaseEntity
{
    public LeaveRequest()
    {

    }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public LeaveType LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public DateTime DateRequested { get; set; }
    public string RequestComments { get; set; }
    public DateTime DateActioned { get; set; }
    public bool? Approved { get; set; }
    public bool Cancelled { get; set; }
    public string RequestingEmployeeId { get; set; } = string.Empty;
}

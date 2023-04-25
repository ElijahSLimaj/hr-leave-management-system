using HrLeaveManagementSystem.Src.Core.Domain.Common;

namespace HrLeaveManagementSystem.Src.Core.Domain;

public class LeaveAllocation : BaseEntity
{
    public LeaveAllocation()
    {

    }
    public string EmployeeId { get; set; }
    public int LeaveTypeId { get; set; }
    public int NumberOfDays { get; set; }
    public LeaveType LeaveType { get; set; }
    public int Period { get; set; }
}

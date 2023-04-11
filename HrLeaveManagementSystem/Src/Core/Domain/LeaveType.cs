using HrLeaveManagementSystem.Src.Core.Domain.Common;

namespace HrLeaveManagementSystem.Src.Core.Domain;
public class LeaveType : BaseEntity
{
    public LeaveType()
    {
    }
    public string Name { get; set; } = string.Empty;
    public int DefaultDays { get; set; }

}

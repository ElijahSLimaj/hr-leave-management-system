using HrLeaveManagementSystem.Src.Core.Domain.Common;

namespace HrLeaveManagementSystem.Src.Core.Domain;

public class LeaveAllocation : BaseEntity
    {
        public LeaveAllocation()
        {

        }
        public int NumberOfDays { get; set; }
        public LeaveType? LeaveType { get; set; }
        public int period { get; set; }
    }

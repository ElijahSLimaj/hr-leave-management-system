using HrLeaveManagementSystem.Src.Core.Application.Contracts.Persistence;
using HrLeaveManagementSystem.Src.Core.Domain;

public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
{
    Task<bool> IsLeaveTypeUnique(string name);
}

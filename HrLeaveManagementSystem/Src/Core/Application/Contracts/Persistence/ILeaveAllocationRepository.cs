using HrLeaveManagementSystem.Src.Core.Application.Contracts.Persistence;
using HrLeaveManagementSystem.Src.Core.Domain;

public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
{
    Task<LeaveAllocation> GetLeaveAllocaiontWithDetails(int id);
    Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
    Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails(string userId);
    Task<bool> AllocationExists(string userId, int leaveTypeId, int period);
    Task AddAllocations(List<LeaveAllocation> allocations);
    Task<LeaveAllocation> GetUserAllocations(string userId, int leaveTypeId);

}

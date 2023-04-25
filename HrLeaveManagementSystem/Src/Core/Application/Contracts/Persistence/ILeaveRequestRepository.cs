using HrLeaveManagementSystem.Src.Core.Application.Contracts.Persistence;
using HrLeaveManagementSystem.Src.Core.Domain;

public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
    Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();
    Task<List<LeaveRequest>> GetLeaveRequestsWithDetails(string userId);
}

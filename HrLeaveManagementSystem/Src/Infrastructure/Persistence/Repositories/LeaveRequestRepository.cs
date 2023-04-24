using HrLeaveManagementSystem.Src.Core.Domain;
using HrLeaveManagementSystem.Src.Infrastructure.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HrLeaveManagementSystem.Src.Infrastructure.Persistence.Repositories;

public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
{
    public LeaveRequestRepository(HrDatabaseContext context) : base(context)
    {
    }
}

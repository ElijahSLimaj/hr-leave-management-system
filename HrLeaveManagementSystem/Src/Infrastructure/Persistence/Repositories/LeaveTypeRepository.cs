using HrLeaveManagementSystem.Src.Core.Domain;
using HrLeaveManagementSystem.Src.Infrastructure.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HrLeaveManagementSystem.Src.Infrastructure.Persistence.Repositories;

public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
{
    public LeaveTypeRepository(HrDatabaseContext context) : base(context)
    {
    }

    public async Task<bool> IsLeaveTypeUnique(string name)
    {
        // _context is a protect field on the GenericRepository class
       return await _context.LeaveTypes.AnyAsync(q => q.Name == name) == false;
    }
}

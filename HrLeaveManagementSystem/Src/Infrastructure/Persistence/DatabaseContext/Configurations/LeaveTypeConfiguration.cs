using HrLeaveManagementSystem.Src.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HrLeaveManagementSystem.Src.Infrastructure.Persistence.DatabaseContext.Configurations;

public class LeaTypeConfigurations : IEntityTypeConfiguration<LeaveType>
{
    public void Configure(EntityTypeBuilder<LeaveType> builder)
    {
        builder.HasData(
            new LeaveType {
                Id = 1,
                Name = "Vacation",
                DefaultDays = 10,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
            }
        );

        builder.Property(q => q.Name).IsRequired().HasMaxLength(100);
    }
}

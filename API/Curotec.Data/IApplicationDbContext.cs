using Curotec.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Curotec.Data;

public interface IApplicationDbContext
{
    DbSet<JobCategory> JobCategories { get; set; }
    DbSet<JobDescription> JobDescriptions { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

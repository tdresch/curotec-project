using Curotec.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Curotec.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{

    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("PUT_AZURE_SQL_CONNECTIONSTRING");
    }



    public virtual DbSet<JobCategory> JobCategories { get; set; }
    public virtual DbSet<JobDescription> JobDescriptions { get; set; }

}

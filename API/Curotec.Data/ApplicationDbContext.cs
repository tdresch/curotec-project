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
        optionsBuilder.UseSqlServer(
            @"Server=tcp:tdresch.database.windows.net,1433;Initial Catalog=curotec;Persist Security Info=False;User ID=tdresch;Password=upgGxr0ANcu0WsV;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }



    public virtual DbSet<JobCategory> JobCategories { get; set; }
    public virtual DbSet<JobDescription> JobDescriptions { get; set; }

}

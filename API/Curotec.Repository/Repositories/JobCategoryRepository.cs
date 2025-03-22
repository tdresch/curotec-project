using Curotec.Data;
using Curotec.Models.Entities;
using Curotec.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Curotec.Repository.Repositories
{
    public class JobCategoryRepository : IJobCategoryRepository
    {
        private readonly IApplicationDbContext _context;

        public JobCategoryRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<JobCategory> CreateJobCategory(JobCategory jobCategory)
        {
            await _context.JobCategories.AddAsync(jobCategory);
            await _context.SaveChangesAsync();

            return jobCategory;
        }

        public async Task<IEnumerable<JobCategory>> GetJobCategories()
        {
            return await _context.JobCategories.AsNoTracking().ToListAsync();
        }
    }
}
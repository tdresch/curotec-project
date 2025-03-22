using Curotec.Data;
using Curotec.Models.Dto;
using Curotec.Models.Entities;
using Curotec.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Curotec.Repository.Repositories
{
    public class JobDescriptionRepository : IJobDescriptionRepository
    {
        private readonly IApplicationDbContext _context;

        public JobDescriptionRepository(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<JobDescription> CreateJobDescription(JobDescription jobDescription)
        {
            _context.JobDescriptions.Add(jobDescription);
            await _context.SaveChangesAsync();
            return jobDescription;
        }

        public async Task DeleteJobDescription(JobDescription jobDescription)
        {
            _context.JobDescriptions.Remove(jobDescription);
            await _context.SaveChangesAsync();
        }

        public async Task<JobDescription> GetJobDescription(Guid id)
        {
            return await _context.JobDescriptions.FindAsync(id);
        }

        public async Task<IEnumerable<ReadJobDescriptionDto>> GetJobDescriptions()
        {
            // mapping the Dto here because I'm not using Automapper, but it's a good idea to use it
            var jobDescriptions = await (from jobDescription in _context.JobDescriptions.AsNoTracking()
                                         join jobCategory in _context.JobCategories on jobDescription.JobCategoryId equals jobCategory.Id
                                         select new ReadJobDescriptionDto
                                         {
                                             Id = jobDescription.Id,
                                             Title = jobDescription.Title,
                                             Description = jobDescription.Description,
                                             CreatedBy = jobDescription.CreatedBy,
                                             DueDate = jobDescription.DueDate,
                                             JobCategoryName = jobCategory.Name
                                         }).ToListAsync();

            return jobDescriptions;
        }

        public async Task<JobDescription> UpdateJobDescription(JobDescription jobDescription)
        {
            _context.JobDescriptions.Update(jobDescription);
            await _context.SaveChangesAsync();
            return jobDescription;
        }
    }
}
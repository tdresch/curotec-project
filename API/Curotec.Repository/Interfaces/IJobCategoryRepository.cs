using Curotec.Models.Entities;

namespace Curotec.Repository.Interfaces
{
    public interface IJobCategoryRepository
    {
        Task<IEnumerable<JobCategory>> GetJobCategories();
        Task<JobCategory> CreateJobCategory(JobCategory jobCategory);
    }
}


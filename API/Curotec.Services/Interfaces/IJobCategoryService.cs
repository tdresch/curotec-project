using Curotec.Models.Dto;

namespace Curotec.Services.Interfaces
{
    public interface IJobCategoryService
    {
        Task<IEnumerable<JobCategoryDto>> GetJobCategories();

        Task<JobCategoryDto> CreateJobCategory(CreateJobCategoryDto jobCategoryDto);
    }
}
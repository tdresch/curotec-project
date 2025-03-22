using Curotec.Models.Dto;
using Curotec.Models.Entities;
using Curotec.Repository.Interfaces;
using Curotec.Services.Interfaces;

namespace Curotec.Services.Services
{
    public class JobCategoryService : IJobCategoryService
    {
        private readonly IJobCategoryRepository _jobCategoryRepository;

        public JobCategoryService(IJobCategoryRepository jobCategoryRepository)
        {
            _jobCategoryRepository = jobCategoryRepository;
        }

        public async Task<JobCategoryDto> CreateJobCategory(CreateJobCategoryDto createJobCategoryDto)
        {


            var jobCategory = await _jobCategoryRepository.CreateJobCategory(new JobCategory
            {
                Name = createJobCategoryDto.Name,
                IsActive = true
            });

            JobCategoryDto jobCategoryDto = new JobCategoryDto()   // This is a DTO object
            {
                Id = jobCategory.Id,
                Name = jobCategory.Name,
                IsActive = jobCategory.IsActive
            };

            return jobCategoryDto;

        }

        public async Task<IEnumerable<JobCategoryDto>> GetJobCategories()
        {
            var jobCategories = await _jobCategoryRepository.GetJobCategories();

            return jobCategories.Select(x => new JobCategoryDto
            {
                Id = x.Id,
                Name = x.Name,
                IsActive = x.IsActive
            }).ToList();
        }
    }
}
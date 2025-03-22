using Curotec.Models.Dto;
using Curotec.Models.Entities;
using Curotec.Repository.Interfaces;
using Curotec.Services.Interfaces;

namespace Curotec.Services.Services
{
    public class JobDescriptionService : IJobDescriptionService
    {

        private readonly IJobDescriptionRepository _jobDescriptionRepository;

        public JobDescriptionService(IJobDescriptionRepository jobDescriptionRepository)
        {
            _jobDescriptionRepository = jobDescriptionRepository;
        }
        public async Task<CreateJobDescriptionDto> CreateJobDescription(CreateJobDescriptionDto jobDescriptionDto)
        {
            //implement here some business rules

            JobDescription jobDescription = new()
            {
                Title = jobDescriptionDto.Title,
                Description = jobDescriptionDto.Description,
                JobCategoryId = jobDescriptionDto.JobCategoryId,
                CreatedBy = jobDescriptionDto.CreatedBy,
                CreatedDate = DateTime.Now,
                DueDate = jobDescriptionDto.DueDate,
                IsVisible = jobDescriptionDto.DueDate < DateTime.Now,
                ImageUrl = jobDescriptionDto.ImageUrl,
                Slug = jobDescriptionDto.Slug,
            };

            jobDescription = await _jobDescriptionRepository.CreateJobDescription(jobDescription);

            return jobDescriptionDto;
        }

        public async Task DeleteJobDescription(Guid id)
        {
            var jobDescription = await _jobDescriptionRepository.GetJobDescription(id);

            if (jobDescription == null)
            {
                throw new Exception("Job Description not found");
            }

            await _jobDescriptionRepository.DeleteJobDescription(jobDescription);
        }

        public async Task<JobDescription> GetJobDescription(Guid id)
        {
            return await _jobDescriptionRepository.GetJobDescription(id);
        }

        public async Task<IEnumerable<ReadJobDescriptionDto>> GetJobDescriptions()
        {
            return await _jobDescriptionRepository.GetJobDescriptions();
        }

        public async Task<UpdateJobDescriptionDto> UpdateJobDescription(UpdateJobDescriptionDto jobDescriptionDto)
        {
            JobDescription jobDescription = await this.GetJobDescription(jobDescriptionDto.Id);

            if (jobDescription == null)
            {
                throw new Exception("Job Description not found");
            }

            //implement here some business rules

            jobDescription.Title = jobDescriptionDto.Title;
            jobDescription.Description = jobDescriptionDto.Description;
            jobDescription.JobCategoryId = jobDescriptionDto.JobCategoryId;
            jobDescription.DueDate = jobDescriptionDto.DueDate;
            jobDescription.IsVisible = jobDescriptionDto.DueDate < DateTime.Now;
            jobDescription.Slug = jobDescriptionDto.Slug;
            jobDescription.ImageUrl = jobDescriptionDto.ImageUrl;


            jobDescription = await _jobDescriptionRepository.UpdateJobDescription(jobDescription);

            return jobDescriptionDto;
        }
    }
}
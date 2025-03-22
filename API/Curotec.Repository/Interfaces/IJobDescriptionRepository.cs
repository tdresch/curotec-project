using Curotec.Models.Dto;
using Curotec.Models.Entities;

namespace Curotec.Repository.Interfaces
{
    public interface IJobDescriptionRepository
    {
        Task<IEnumerable<ReadJobDescriptionDto>> GetJobDescriptions();
        Task<JobDescription> GetJobDescription(Guid id);
        Task<JobDescription> CreateJobDescription(JobDescription jobDescription);
        Task<JobDescription> UpdateJobDescription(JobDescription jobDescription);
        Task DeleteJobDescription(JobDescription jobDescription);
    }
}
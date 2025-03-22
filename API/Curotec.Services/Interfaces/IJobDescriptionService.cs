using Curotec.Models.Dto;
using Curotec.Models.Entities;

namespace Curotec.Services.Interfaces
{
    public interface IJobDescriptionService
    {

        Task<IEnumerable<ReadJobDescriptionDto>> GetJobDescriptions();
        Task<JobDescription> GetJobDescription(Guid id);
        Task<CreateJobDescriptionDto> CreateJobDescription(CreateJobDescriptionDto jobDescriptionDto);
        Task<UpdateJobDescriptionDto> UpdateJobDescription(UpdateJobDescriptionDto jobDescriptionDto);
        Task DeleteJobDescription(Guid id);
    }
}
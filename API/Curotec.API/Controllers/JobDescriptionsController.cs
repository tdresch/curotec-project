using Curotec.Models.Dto;
using Curotec.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Curotec.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobDescriptionsController : ControllerBase
{
    private readonly ILogger<JobDescriptionsController> _logger;
    private readonly IJobDescriptionService _jobDescriptionService;

    public JobDescriptionsController(ILogger<JobDescriptionsController> logger, IJobDescriptionService jobDescriptionService)
    {
        _logger = logger;
        _jobDescriptionService = jobDescriptionService;
    }

    [HttpGet]
    public async Task<IActionResult> GetJobDescriptions()
    {
        var result = await _jobDescriptionService.GetJobDescriptions();

        return Ok(result);

    }
    [HttpPost("create")]
    public async Task<IActionResult> CreateJobDescriptions([FromBody] CreateJobDescriptionDto jobDescriptionDto)
    {
        await _jobDescriptionService.CreateJobDescription(jobDescriptionDto);
        return Ok(jobDescriptionDto);
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateJobDescriptions([FromBody] UpdateJobDescriptionDto jobDescriptionDto)
    {
        await _jobDescriptionService.UpdateJobDescription(jobDescriptionDto);
        return Ok(jobDescriptionDto);
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteJobDescriptions([FromRoute] Guid id)
    {
        await _jobDescriptionService.DeleteJobDescription(id);
        return NoContent();

    }
}
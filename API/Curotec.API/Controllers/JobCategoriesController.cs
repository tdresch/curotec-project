using Curotec.Models.Dto;
using Curotec.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Curotec.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobCategoriesController : ControllerBase
    {
        private readonly ILogger<JobCategoriesController> _logger;
        private readonly IJobCategoryService _jobCategoryService;

        public JobCategoriesController(ILogger<JobCategoriesController> logger, IJobCategoryService jobCategoryService)
        {
            _logger = logger;
            _jobCategoryService = jobCategoryService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateJobCategory(CreateJobCategoryDto jobCategoryDto)
        {
            var result = await _jobCategoryService.CreateJobCategory(jobCategoryDto);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetJobCategories()
        {
            var result = await _jobCategoryService.GetJobCategories();

            return Ok(result);
        }

    }
}
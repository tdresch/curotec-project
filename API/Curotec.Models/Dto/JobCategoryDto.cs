namespace Curotec.Models.Dto
{
    public class JobCategoryDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }

        public bool IsActive { get; set; }
    }

    public class CreateJobCategoryDto
    {
        public required string Name { get; set; }
        
    }

}
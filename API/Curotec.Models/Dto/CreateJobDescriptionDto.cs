namespace Curotec.Models.Dto
{
    public class CreateJobDescriptionDto
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string CreatedBy { get; set; }
        public required string Slug { get; set; }

        public string? ImageUrl { get; set; }

        public DateTime DueDate { get; set; }

        public Guid JobCategoryId { get; set; }


    }
}
namespace Curotec.Models.Entities
{
    public class JobDescription
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public required string CreatedBy { get; set; }
        /// <summary>
        /// Slug is a unique identifier for the job description
        /// </summary>
        public required string Slug { get; set; }

        public string? ImageUrl { get; set; }

        public DateTime DueDate { get; set; }
        public Boolean IsVisible { get; set; }

        public Guid JobCategoryId { get; set; }
        public JobCategory JobCategory { get; set; }

    }
}
namespace Curotec.Models.Dto
{
    public class ReadJobDescriptionDto
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string CreatedBy { get; set; }

        public string? ImageUrl { get; set; }

        public DateTime DueDate { get; set; }

        public string? JobCategoryName { get; set; }

        public bool IsVisible { get; set; }

    }
}
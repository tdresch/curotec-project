namespace Curotec.Models.Entities
{
    public class JobCategory
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<JobDescription> JobDescriptions { get; set; } = new List<JobDescription>();
    }
}
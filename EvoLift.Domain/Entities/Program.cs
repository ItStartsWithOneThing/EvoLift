namespace EvoLift.Domain.Entities
{
    public class Program
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public bool IsCurrent { get; set; }

        public required ICollection<WorkoutTemplate> WorkoutTemplates { get; set; }
    }
}

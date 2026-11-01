using EvoLift.Domain.Enums;

namespace EvoLift.Domain.Entities
{
    public class Exercise
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string Image { get; set; }
        public bool IsPredefined { get; set; }

        public Guid MuscleGroupId { get; set; }
        public required MuscleGroup MuscleGroup { get; set; }
    }
}

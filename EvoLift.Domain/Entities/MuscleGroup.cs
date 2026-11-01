using EvoLift.Domain.Enums;

namespace EvoLift.Domain.Entities
{
    public class MuscleGroup
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public CalendarDisplayColors CalendarDisplayColor { get; set; }
        public CalendarDisplayShapes CalendarDisplayShape { get; set; }
        public required ICollection<Exercise> Exercises { get; set; }
    }
}

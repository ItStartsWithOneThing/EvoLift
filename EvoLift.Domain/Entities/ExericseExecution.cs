namespace EvoLift.Domain.Entities
{
    public class ExericseExecution
    {
        public Guid Id { get; set; }
        public int WorkoutSequenceNumber { get; set; }
        public DateTime AddedAt { get; set; }

        public Guid ExerciseId { get; set; }
        public required Exercise Exercise { get; set; }
        public ICollection<Set>? Sets { get; set; }
    }
}

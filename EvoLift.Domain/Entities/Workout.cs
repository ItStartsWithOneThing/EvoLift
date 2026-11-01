namespace EvoLift.Domain.Entities
{
    public class Workout
    {
        public Guid Id { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }
        public int DurationInSeconds { get; set; }
        public string? Notes { get; set; }

        public ICollection<CardioExerciseExecution>? CardioExecutions { get; set; }
        public ICollection<ExericseExecution>? ExericseExecutions { get; set; }
    }
}

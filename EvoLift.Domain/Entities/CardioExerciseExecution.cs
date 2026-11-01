namespace EvoLift.Domain.Entities
{
    public class CardioExerciseExecution
    {
        public Guid Id { get; set; }
        public int WorkoutSequenceNumber { get; set; }
        public int DistanceInMeters { get; set; }
        public int DurationInSeconds { get; set; }
        public int? AveragePace { get; set; }
        public int? Incline { get; set; }
        public int? AverageHeartRate { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }

        public Guid CardioExerciseId { get; set; }
        public required CardioExercise CardioExercise { get; set; }
    }
}

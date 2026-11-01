namespace EvoLift.Domain.Entities
{
    public class Set
    {
        public Guid Id { get; set; }
        public int ExericseExecutionSequenceNumber { get; set; }
        public int Repetitions { get; set; }
        public double WeightKg { get; set; }
        public bool IsWarmup { get; set; }
        public DateTime AddedAt { get; set; }

        public Guid ExericseExecutionId { get; set; }
        public required ExericseExecution ExericseExecution { get; set; }
    }
}

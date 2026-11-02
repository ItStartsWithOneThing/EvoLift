namespace EvoLift.Domain.Entities
{
    public class WorkoutTemplate
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public int ProgramSequenceNumber { get; set; }

        public ICollection<Exercise>? Exericses { get; set; }
        public ICollection<CardioExercise>? CardioExercises { get; set; }

        public Guid ProgramId { get; set; }
        public required Program Program { get; set; }
    }
}

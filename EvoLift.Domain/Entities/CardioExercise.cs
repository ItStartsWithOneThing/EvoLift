namespace EvoLift.Domain.Entities
{
    public class CardioExercise
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Image { get; set; }
        public bool IsPredefined { get; set; }
    }
}

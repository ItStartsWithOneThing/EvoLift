using EvoLift.Domain.Enums;

namespace EvoLift.Domain.Entities
{
    public class UserSettings
    {
        public Guid Id { get; set; }
        public Languages Language { get; set; }
        public MeasurementSystems MeasurementSystem { get; set; }
        public Themes Theme { get; set; }
        public bool KeepActiveDisplay { get; set; }
    }
}

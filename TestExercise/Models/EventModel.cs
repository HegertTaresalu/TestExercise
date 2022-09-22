namespace TestExercise.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public DateTime StartDate { get; set; }

        public string? EventLocation { get; set; }

        public string? ExtraInfo { get; set; }
    }
}

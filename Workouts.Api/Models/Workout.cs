public class Workout
{
    public int Id { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public required Exercise[] Exercise { get; set; }
}
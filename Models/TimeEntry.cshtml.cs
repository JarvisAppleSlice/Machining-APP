public enum EntryType
{
    ClockIn,
    ClockOut
}

public class TimeEntry
{
    public int Id { get; set; }
    public DateTime Timestamp { get; set; }
    public EntryType Type { get; set; }
    public string Notes { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
public class CalendarDay
{
    public DateTime Date { get; set; }
    public bool IsToday { get; set; }
    public bool IsCurrentMonth { get; set; }
    public bool HasEvent { get; set; }
    public bool IsLongEvent { get; set; }
    public bool IsEventStart { get; set; }
    public bool IsEventEnd { get; set; }
}


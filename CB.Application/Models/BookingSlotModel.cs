namespace CB.Application.Models;

public class BookingSlotModel
{
    public long Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public string? DateMonth { get; set; }
}

namespace MiniEventBooking.Domain;

public class Event
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public string Location { get; set; } = "";

    public DateTime Date { get; set; }

    public List<Booking> Bookings { get; set; } = new();
}
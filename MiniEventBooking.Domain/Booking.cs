namespace MiniEventBooking.Domain;

public class Booking
{
    public int Id { get; set; }

    public int EventId { get; set; }
    public Event? Event { get; set; }

    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public DateTime BookingDate { get; set; } = DateTime.Now;
}
using MiniEventBooking.Domain;

namespace MiniEventBooking.Application.Interfaces;

public interface IBookingRepository
{
    Task<List<Booking>> GetAllAsync();
    Task<Booking> CreateAsync(Booking booking);
}
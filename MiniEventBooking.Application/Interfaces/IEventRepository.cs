using MiniEventBooking.Domain;

namespace MiniEventBooking.Application.Interfaces;

public interface IEventRepository
{
    Task<List<Event>> GetAllAsync();
    Task<Event> CreateAsync(Event newEvent);
}
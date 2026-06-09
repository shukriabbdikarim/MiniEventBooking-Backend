using Microsoft.EntityFrameworkCore;
using MiniEventBooking.Application.Interfaces;
using MiniEventBooking.Domain;
using MiniEventBooking.Infrastructure.Data;

namespace MiniEventBooking.Infrastructure.Repositories;

public class EventRepository : IEventRepository
{
    private readonly AppDbContext _context;

    public EventRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Event>> GetAllAsync()
    {
        return await _context.Events.ToListAsync();
    }

    public async Task<Event> CreateAsync(Event newEvent)
    {
        _context.Events.Add(newEvent);
        await _context.SaveChangesAsync();

        return newEvent;
    }
}
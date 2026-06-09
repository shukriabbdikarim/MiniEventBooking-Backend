using Microsoft.EntityFrameworkCore;
using MiniEventBooking.Application.Interfaces;
using MiniEventBooking.Domain;
using MiniEventBooking.Infrastructure.Data;

namespace MiniEventBooking.Infrastructure.Repositories;

public class BookingRepository : IBookingRepository
{
    private readonly AppDbContext _context;

    public BookingRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Booking>> GetAllAsync()
    {
        return await _context.Bookings.ToListAsync();
    }

    public async Task<Booking> CreateAsync(Booking booking)
    {
        _context.Bookings.Add(booking);
        await _context.SaveChangesAsync();

        return booking;
    }
}
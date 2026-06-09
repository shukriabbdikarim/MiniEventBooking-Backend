using Microsoft.EntityFrameworkCore;
using MiniEventBooking.Domain;

namespace MiniEventBooking.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Event> Events { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Booking> Bookings { get; set; }
}
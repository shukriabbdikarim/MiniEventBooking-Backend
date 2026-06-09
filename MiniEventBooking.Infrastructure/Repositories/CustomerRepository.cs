using Microsoft.EntityFrameworkCore;
using MiniEventBooking.Application.Interfaces;
using MiniEventBooking.Domain;
using MiniEventBooking.Infrastructure.Data;

namespace MiniEventBooking.Infrastructure.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly AppDbContext _context;

    public CustomerRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Customer>> GetAllAsync()
    {
        return await _context.Customers.ToListAsync();
    }

    public async Task<Customer> CreateAsync(Customer customer)
    {
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();

        return customer;
    }
}
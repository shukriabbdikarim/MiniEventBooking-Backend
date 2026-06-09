using MiniEventBooking.Domain;

namespace MiniEventBooking.Application.Interfaces;

public interface ICustomerRepository
{
    Task<List<Customer>> GetAllAsync();
    Task<Customer> CreateAsync(Customer customer);
}
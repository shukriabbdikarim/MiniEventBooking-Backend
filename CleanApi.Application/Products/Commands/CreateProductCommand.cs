using CleanApi.Domain.Entities;
using MediatR;

namespace CleanApi.Application.Products.Commands;

public record CreateProductCommand(
    string Name,
    decimal Price,
    int CategoryId
) : IRequest<Product>;
using MediatR;

namespace CleanApi.Application.Products.Commands;

public record UpdateProductCommand(
    int Id,
    string Name,
    decimal Price,
    int CategoryId
) : IRequest<bool>;
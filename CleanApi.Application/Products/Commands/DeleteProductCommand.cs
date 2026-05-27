using MediatR;

namespace CleanApi.Application.Products.Commands;

public record DeleteProductCommand(int Id) : IRequest<bool>;
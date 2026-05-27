using CleanApi.Domain.Entities;
using MediatR;

namespace CleanApi.Application.Products.Queries;

public record GetProductByIdQuery(int Id) : IRequest<Product?>;
using CleanApi.Domain.Entities;
using MediatR;

namespace CleanApi.Application.Products.Queries;

public record GetAllProductsQuery() : IRequest<List<Product>>;
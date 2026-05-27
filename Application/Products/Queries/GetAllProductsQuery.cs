using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.Products.Queries;

public class GetAllProductsQuery : IRequest<List<Product>>
{
}

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
{
    private readonly IProductRepository _repository;

    public GetAllProductsQueryHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}
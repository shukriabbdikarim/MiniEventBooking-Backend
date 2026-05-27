using CleanApi.Application.Interfaces;
using CleanApi.Domain.Entities;
using MediatR;

namespace CleanApi.Application.Products.Commands;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
{
    private readonly IProductRepository _repository;

    public UpdateProductCommandHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Id = request.Id,
            Name = request.Name,
            Price = request.Price,
            CategoryId = request.CategoryId
        };

        return await _repository.UpdateAsync(product);
    }
}
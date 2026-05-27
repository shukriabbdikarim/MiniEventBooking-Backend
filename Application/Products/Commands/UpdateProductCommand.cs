using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.Products.Commands;

public class UpdateProductCommand : IRequest<Unit>
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public decimal Price { get; set; }

    public int CategoryId { get; set; }
}

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
{
    private readonly IProductRepository _repository;

    public UpdateProductCommandHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Id = request.Id,
            Name = request.Name,
            Price = request.Price,
            CategoryId = request.CategoryId
        };

        await _repository.UpdateAsync(product);

        return Unit.Value;
    }
}
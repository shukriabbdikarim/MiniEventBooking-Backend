using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.Products.Commands;

public class CreateProductCommand : IRequest<Unit>
{
    public string Name { get; set; } = "";

    public decimal Price { get; set; }

    public int CategoryId { get; set; }
}

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Unit>
{
    private readonly IProductRepository _repository;

    public CreateProductCommandHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Name = request.Name,
            Price = request.Price,
            CategoryId = request.CategoryId
        };

        await _repository.AddAsync(product);

        return Unit.Value;
    }
}
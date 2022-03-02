using AutoMapper;

using MediatR;

namespace OA.Application.Products.CQRS.Commands.CreateProduct;

public class CreateProductCommandHandler
    : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
{
    private readonly IProductRepository productRepository;
    private readonly IMapper mapper;

    public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
    {
        this.productRepository = productRepository;
        this.mapper = mapper;
    }

    public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
    {
        var product = this.mapper.Map<Product>(request);
        await this.productRepository.Add(product);
        return await Task.FromResult(new CreateProductCommandResponse(true));
    }
}

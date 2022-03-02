using AutoMapper;

using MediatR;

namespace OA.Application.Products.CQRS.Queries.GetAllProduct;

public class GetAllProductQueryHandler
    : IRequestHandler<GetAllProductQueryRequest, IEnumerable<GetAllProductQueryResponse>>
{
    private readonly IProductRepository productRepository;
    private readonly IMapper mapper;

    public GetAllProductQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        this.productRepository = productRepository;
        this.mapper = mapper;
    }

    public async Task<IEnumerable<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
    {
        var dbList = await this.productRepository.GetAll();

        if (request.NameFilter != null)
            dbList = dbList.Where(x => x.Name.ToLower().Contains(request.NameFilter.ToLower()));

        var list = this.mapper.Map<IEnumerable<GetAllProductQueryResponse>>(dbList);
        return await Task.FromResult(list);
    }
}

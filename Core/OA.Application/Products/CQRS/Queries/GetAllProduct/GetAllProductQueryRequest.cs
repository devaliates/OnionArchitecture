using MediatR;

namespace OA.Application.Products.CQRS.Queries.GetAllProduct;

public class GetAllProductQueryRequest
    : IRequest<IEnumerable<GetAllProductQueryResponse>>
{
    public String? NameFilter { get; set; }
}

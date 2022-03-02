using MediatR;

using Microsoft.AspNetCore.Mvc;

using OA.Application.Products.CQRS.Commands.CreateProduct;
using OA.Application.Products.CQRS.Queries.GetAllProduct;

namespace OA.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IMediator mediator;

    public ProductsController(IMediator mediator)
        => this.mediator = mediator;

    [HttpGet("get-all")]
    public async Task<IEnumerable<GetAllProductQueryResponse>> GetAll([FromQuery] GetAllProductQueryRequest request)
        => await this.mediator.Send(request);

    [HttpPost("create")]
    public async Task<CreateProductCommandResponse> Create([FromBody] CreateProductCommandRequest request)
        => await this.mediator.Send(request);
}

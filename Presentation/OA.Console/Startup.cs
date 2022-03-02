using MediatR;

using OA.Application.Products.CQRS.Commands.CreateProduct;
using OA.Application.Products.CQRS.Queries.GetAllProduct;

namespace OA.Console;

public class Startup
{

    public Startup(IMediator mediators)
    {
        var createRequest = new CreateProductCommandRequest()
        {
            Name = "",
        };

        var validationResult = new CreateProductCommandValidator().Validate(createRequest);

        ValidatorExecuter.HasError(validationResult);

        var createResponse = mediators.Send(createRequest).Result;


        var getAllRequest = new GetAllProductQueryRequest();
        var liste = mediators.Send(getAllRequest).Result;
    }


}

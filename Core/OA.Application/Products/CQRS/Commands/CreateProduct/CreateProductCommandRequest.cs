using MediatR;

namespace OA.Application.Products.CQRS.Commands.CreateProduct;

public class CreateProductCommandRequest
    : IRequest<CreateProductCommandResponse>
{
    public String Name { get; set; }

    public CreateProductCommandRequest()
    {
        this.Name = String.Empty;
    }
}

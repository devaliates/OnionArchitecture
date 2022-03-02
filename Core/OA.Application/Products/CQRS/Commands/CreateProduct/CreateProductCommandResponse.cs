namespace OA.Application.Products.CQRS.Commands.CreateProduct;

public class CreateProductCommandResponse
{
    public Boolean Created { get; set; }

    public CreateProductCommandResponse(Boolean created)
    {
        this.Created = created;
    }
}

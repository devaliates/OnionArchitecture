namespace OA.Application.Products.CQRS.Queries.GetAllProduct;

public class GetAllProductQueryResponse
{
    public String Name { get; set; }

    public GetAllProductQueryResponse()
    {
        this.Name = String.Empty;
    }
}

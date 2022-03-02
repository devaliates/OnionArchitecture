using OA.Application.Common.Entities;

namespace OA.Application.Products;

public class Product
    : BaseEntity
{
    public String Name { get; set; }

    public Product()
    {
        this.Name = String.Empty;
    }
}

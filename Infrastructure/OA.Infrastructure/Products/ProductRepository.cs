using OA.Application.Products;

namespace OA.Infrastructure.Products;

public class ProductRepository
    : IProductRepository
{
    private List<Product> products
        = new()
        {
            new Product() { Name = "Ürün 1" },
            new Product() { Name = "Ürün 2" },
            new Product() { Name = "Ürün 3" },
            new Product() { Name = "Ürün 4" },
            new Product() { Name = "Ürün 5" },
        };

    public async Task Add(Product product)
    {
        product.Id = Guid.NewGuid();
        this.products.Add(product);
        await Task.CompletedTask;
    }

    public async Task<IEnumerable<Product>> GetAll()
        => await Task.FromResult(this.products);
}

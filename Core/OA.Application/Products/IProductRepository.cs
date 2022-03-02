namespace OA.Application.Products;

public interface IProductRepository
{
    public Task<IEnumerable<Product>> GetAll();
    public Task Add(Product product);
}

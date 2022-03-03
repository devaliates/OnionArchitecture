using NUnit.Framework;
using OA.Application.Products.CQRS.Queries.GetAllProduct;
using System.Threading;
using System.Linq;
using OA.Application.Test.TestTools;
using System.Threading.Tasks;

namespace OA.Application.Test.Products.CQRS.Queries;

public class GetAllProductQueryTests
{
    private GetAllProductQueryHandler getAllProductQueryHandler;

    public GetAllProductQueryTests()
    {
        this.getAllProductQueryHandler
            = new GetAllProductQueryHandler(
                new TestProductRepository(),
                TestMapperTool.Mapper);
    }

    [SetUp]
    public async Task SetUp()
        => this.getAllProductQueryHandler
            = new GetAllProductQueryHandler(
                new TestProductRepository(),
                TestMapperTool.Mapper);

    [TestCase]
    public async Task GetAllProductQueryHandler()
    {
        var list = await this.getAllProductQueryHandler.Handle(new GetAllProductQueryRequest(), new CancellationToken());

        Assert.NotZero(list.Count());
    }
}

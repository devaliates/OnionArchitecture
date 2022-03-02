using NUnit.Framework;
using OA.Application.Products.CQRS.Queries.GetAllProduct;
using System.Threading;
using System.Linq;
using OA.Application.Test.TestTools;

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
    public void SetUp()
        => this.getAllProductQueryHandler
            = new GetAllProductQueryHandler(
                new TestProductRepository(),
                TestMapperTool.Mapper);

    [TestCase]
    public void GetAllProductQueryHandler()
    {
        var list = this.getAllProductQueryHandler.Handle(new GetAllProductQueryRequest(), new CancellationToken()).Result;

        Assert.NotZero(list.Count());
    }
}

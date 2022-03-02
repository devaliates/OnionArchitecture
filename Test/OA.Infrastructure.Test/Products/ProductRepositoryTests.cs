using NUnit.Framework;

using OA.Application.Products;
using OA.Infrastructure.Products;

using System;
using System.Collections.Generic;
using System.Linq;

namespace OA.Infrastructure.Test.Products;

public class ProductRepositoryTests
{
    private ProductRepository productRepository;

    public ProductRepositoryTests()
        => this.productRepository = new ProductRepository();

    [SetUp]
    public void Setup()
        => this.productRepository = new ProductRepository();

    [TestCase]
    public void GetAll()
    {
        var list = this.productRepository.GetAll().Result;

        Assert.NotNull(list, "Deneme notnull");
        Assert.NotZero(list.Count(), "Deneme zero");
    }

    [TestCaseSource(nameof(AddTestCases))]
    public void Add(Product product)
    {
        this.productRepository.Add(product).Wait();

        Assert.AreNotEqual(Guid.Empty, product.Id);
    }

    public static IEnumerable<TestCaseData> AddTestCases()
    {
        yield return new TestCaseData(new Product() { Name = "Case 1 Product" });
        yield return new TestCaseData(new Product() { Name = "Case 2 Product" });
        yield return new TestCaseData(new Product() { Name = "Case 3 Product" });
    }
}

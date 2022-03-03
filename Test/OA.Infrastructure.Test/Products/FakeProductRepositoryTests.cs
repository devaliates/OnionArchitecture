﻿using NUnit.Framework;

using OA.Application.Products;
using OA.Infrastructure.Products;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Infrastructure.Test.Products;

public class FakeProductRepositoryTests
{
    private FakeProductRepository productRepository;

    public FakeProductRepositoryTests()
        => this.productRepository = new FakeProductRepository();

    [SetUp]
    public async Task SetUp()
        => this.productRepository = new FakeProductRepository();

    [TestCase]
    public async Task GetAll()
    {
        var list = await this.productRepository.GetAll();

        Assert.NotNull(list, "Deneme notnull");
        Assert.NotZero(list.Count(), "Deneme zero");
    }

    [TestCaseSource(nameof(AddTestCases))]
    public async Task Add(Product product)
    {
        if (product == null)
        {
#pragma warning disable CS8604 // Possible null reference argument.
            Assert.ThrowsAsync<ArgumentNullException>(
                async ()
                    => await this.productRepository.Add(product));
#pragma warning restore CS8604 // Possible null reference argument.

            return;
        }

        await this.productRepository.Add(product);

        Assert.AreNotEqual(Guid.Empty, product.Id);
    }

    public static IEnumerable<TestCaseData> AddTestCases()
    {
        yield return new TestCaseData(new Product() { Name = "Case 1 Product" });
        yield return new TestCaseData(null);
    }
}

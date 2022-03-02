using AutoMapper;

using OA.Application.Products;
using OA.Application.Products.CQRS.Commands.CreateProduct;
using OA.Application.Products.CQRS.Queries.GetAllProduct;

namespace OA.Application.Mapping;

public class GeneralMapping
    : Profile
{
    public GeneralMapping()
    {
        CreateMap<Product, GetAllProductQueryResponse>()
            .ReverseMap();

        CreateMap<Product, CreateProductCommandRequest>()
            .ReverseMap();
    }
}

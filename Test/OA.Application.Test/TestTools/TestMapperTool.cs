using AutoMapper;

using OA.Application.Mapping;

namespace OA.Application.Test.TestTools;

public static class TestMapperTool
{
    public static IMapper Mapper
    {
        get => CreateMapper();
    }

    private static IMapper CreateMapper()
    {
        return new Mapper(new MapperConfiguration(x => x.AddProfile(new GeneralMapping())));
    }
}

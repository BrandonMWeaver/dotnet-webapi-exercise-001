using AutoMapper;

using dotnet_webapi_exercise_001.Dtos;
using dotnet_webapi_exercise_001.Models;

namespace dotnet_webapi_exercise_001.Profiles
{
    public class TestmodelsProfile : Profile
    {
        public TestmodelsProfile()
        {
            CreateMap<TestModel, TestModelReadDto>();
            CreateMap<TestModelCreateDto, TestModel>();
        }
    }
}

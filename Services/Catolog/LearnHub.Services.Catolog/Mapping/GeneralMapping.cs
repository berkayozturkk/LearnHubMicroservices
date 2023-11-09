using AutoMapper;
using LearnHub.Services.Catolog.Dtos;
using LearnHub.Services.Catolog.Models;

namespace LearnHub.Services.Catolog.Mapping;

public class GeneralMapping : Profile
{
    public GeneralMapping()
    {
        CreateMap<Course, CourseDto>().ReverseMap();
        CreateMap<Course, CourseCreateDto>().ReverseMap();
        CreateMap<Course, CourseUpdateDto>().ReverseMap();

        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Feature, FeatureDto>().ReverseMap();
    }
}

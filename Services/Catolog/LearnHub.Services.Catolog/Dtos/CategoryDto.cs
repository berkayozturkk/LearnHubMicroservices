using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace LearnHub.Services.Catolog.Dtos;

public class CategoryDto
{
    public string Id { get; set; }
    public string Name { get; set; }
}

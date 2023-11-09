using LearnHub.Services.Catolog.Dtos;
using LearnHub.Services.Catolog.Models;
using LearnHub.Shared.Dtos;

namespace LearnHub.Services.Catolog.Services;

public interface ICategoryService
{
    Task<Response<List<CategoryDto>>> GetAllAsync();

    Task<Response<CategoryDto>> CreateAsync(Category category);

    Task<Response<CategoryDto>> GetByIdAsync(string id);
}


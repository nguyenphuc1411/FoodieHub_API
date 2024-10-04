using FoodieHub_API.Data.Entities;
using FoodieHub_API.DTOs;

namespace FoodieHub_API.Services
{
    public interface ICategoryService
    {
        Task<APIResponse<List<Category>>> GetAll();

        Task<APIResponse<List<object>>> GetExample();
    }
}

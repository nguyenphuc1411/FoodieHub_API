using FoodieHub_API.Data;
using FoodieHub_API.Data.Entities;
using FoodieHub_API.DTOs;
using FoodieHub_API.Services;
using Microsoft.EntityFrameworkCore;
namespace FoodieHub_API.Repositories
{
    public class CategoryService:ICategoryService
    {
        private readonly AppDbConext _context;

        public CategoryService(AppDbConext context)
        {
            _context = context;
        }

        public async Task<APIResponse<List<Category>>> GetAll()
        {
            try
            {
                var recipes = await _context.Categorys.ToListAsync();
                return new APIResponse<List<Category>>()
                {
                    Success = true,
                    Message = "Recipes retrieved successfully",
                    Data = recipes,
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new APIResponse<List<Category>>()
                {
                    Success = false,
                    Message = ex.Message,
                    Data = null,
                    StatusCode = 500
                };
            }
        }

        public async Task<APIResponse<List<object>>> GetExample()
        {
            try
            {
                var categories = await _context.Categorys
                   .Select(ct => new 
                   {
                       CategoryID = ct.CategoryID,
                       CatogoryName = ct.CategoryName,
                       ImageURL = ct.ImageURL,
                       Recipes = ct.Recipes.ToList(),
                   })
                   .ToListAsync();


                var data = categories.Cast<object>().ToList();
                return new APIResponse<List<object>>()
                {
                    Success = true,
                    Message = "Recipes retrieved successfully",
                    Data = data,
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new APIResponse<List<object>>()
                {
                    Success = false,
                    Message = ex.Message,
                    StatusCode = 500
                };
            }
        }
    }
}

using FoodieHub_API.Data;
using FoodieHub_API.Data.Entities;
using FoodieHub_API.DTOs;
using FoodieHub_API.Services;
using Microsoft.EntityFrameworkCore;

namespace FoodieHub_API.Repositories
{
    public class RecipeService : IRecipeService
    {
        private readonly AppDbConext _context;

        public RecipeService(AppDbConext context)
        {
            _context = context;
        }

       
    }
}

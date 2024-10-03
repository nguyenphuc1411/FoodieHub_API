namespace FoodieHub_API.Data.Entities
{
    public class Recipe_Ingredient
    {
        public decimal Quantity { get; set; }

        // // Foreign Key Property

        public int RecipeID {  get; set; }
        public int IngredientID {  get; set; }

        // Foreign Key Link

        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}

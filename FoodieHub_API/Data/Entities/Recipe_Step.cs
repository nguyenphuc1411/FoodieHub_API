using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodieHub_API.Data.Entities
{
    public class Recipe_Step
    {
        [Key]
        public int StepID { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Title { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string Description { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string? ImageURL {  get; set; }

        // Foreign Key Property
        public int RecipeID {  get; set; }

        // Foreign Key Link
        public Recipe Recipe { get; set; }
    }
}

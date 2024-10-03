using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodieHub_API.Data.Entities
{
    public class Recipe
    {
        [Key]
        public int RecipeID { get; set; }
        [Column(TypeName = "varchar(255)")]

        public string Title { get; set; }
        [Column(TypeName = "varchar(255)")]

        public string ImageURL { get; set; }

        public string Description { get; set; }

        public int Portion { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string CookingTime { get; set; }

        public DateTime Created_At { get; set; }= DateTime.Now;
        public DateTime? Updated_At { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsBanned {  get; set; }= false;

        // Foreign Key Property
        public int CategoryID { get; set; }

        [Column(TypeName ="nvarchar(450)")]
        public string UserID { get; set; }

        // Foreign Key Link

        public Category Category { get; set; }

        public ApplicationUser User { get; set; }

        // Collection Link
        public ICollection<Recipe_Ingredient> Recipe_Ingredients { get; set; }

        public ICollection<Recipe_Step> Recipe_Steps{ get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Favorite> Favorites { get; set; }

        public ICollection<Report> Reports { get; set; }
    }
}

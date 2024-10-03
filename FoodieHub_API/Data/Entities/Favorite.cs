using System.ComponentModel.DataAnnotations.Schema;

namespace FoodieHub_API.Data.Entities
{
    public class Favorite
    {
        public DateTime Created_At { get; set; } = DateTime.Now;

        // Foreign Key Property
        public int RecipeID { get; set; }


        [Column(TypeName = "nvarchar(450)")]
        public string UserID { get; set; }

        // Foreign Key Link
        public Recipe Recipe { get; set; }

        public ApplicationUser User { get; set; }
    }
}

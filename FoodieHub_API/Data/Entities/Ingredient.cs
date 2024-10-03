using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodieHub_API.Data.Entities
{
    public class Ingredient
    {
        [Key]
        public int IngredientID { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string IngredientName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Unit { get; set; }

        // Foreign Key property
        [Column(TypeName = "nvarchar(450)")]
        public string UserID {  get; set; }
        // ID người tạo nguyên liệu có thể admin hoặc người dùng.
        // Khi lấy danh sách nguyên liệu cho người dùng sẽ hiển thị những nguyên liệu do admin và nguyên liệu tự người dùng nhập

        // Foreign Key Link
        public ApplicationUser User { get; set; }

        // Collection Link
        public ICollection<Recipe_Ingredient> Recipe_Ingredients { get; set; }
    }
}

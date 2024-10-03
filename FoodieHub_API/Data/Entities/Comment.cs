using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodieHub_API.Data.Entities
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string ContentText { get; set; }
        public DateTime Created_At { get; set; } = DateTime.Now;
        public DateTime? Updated_At { get; set; }

        // Foreign Key Property
        [Column(TypeName = "nvarchar(450)")]
        public string UserID { get; set; }

        public int RecipeID { get; set; }

        // Foreign Key Link

        public ApplicationUser User { get; set; }

        public Recipe Recipe { get; set; }
    }
}

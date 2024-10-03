using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodieHub_API.Data.Entities
{
    public class ApplicationUser:IdentityUser
    {
        [Column(TypeName ="varchar(150)")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string? Bio {  get; set; }

        [Column(TypeName = "varchar(255)")]
        public string? Avatar {  get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Status {  get; set; }

        public DateTime Created_At {  get; set; } = DateTime.Now;

        public DateTime? Updated_At { get;set; } = DateTime.Now;


        // Foreign Key Link
        public ICollection<Notification> Notifications { get; set; }

        public ICollection<Follow> Follows { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Favorite> Favorites { get; set; }

        public ICollection<Report> Reports { get; set; }

        public ICollection<Recipe> Recipes { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }

    }
}

using FoodieHub_API.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodieHub_API.Data
{
    public class AppDbConext:IdentityDbContext<ApplicationUser>
    {
        public AppDbConext(DbContextOptions<AppDbConext> options):base(options) { }

        #region DBSET
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Recipe_Ingredient> Recipe_Ingredients { get; set; }
        public DbSet<Recipe_Step> Recipe_Steps { get; set; }
        public DbSet<Report> Reports { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Cấu hình các thuộc tính khóa

            // Cấu hình khóa ngoại liên quan đến User
            builder.Entity<ApplicationUser>(options =>
            {
                options.HasMany(u => u.Notifications).WithOne(n => n.User).HasForeignKey(n => n.UserID);
                options.HasMany(u => u.Follows).WithOne(f => f.User).HasForeignKey(f => new {f.FollowerID,f.FollowedID});
                options.HasMany(u => u.Comments).WithOne(c => c.User).HasForeignKey(c => c.UserID);
                options.HasMany(u => u.Favorites).WithOne(f => f.User).HasForeignKey(f => f.UserID);
                options.HasMany(u => u.Recipes).WithOne(r => r.User).HasForeignKey(r => r.UserID);
                options.HasMany(u => u.Reports).WithOne(r => r.User).HasForeignKey(r => new {r.ReporterID,r.HandlerID});
                options.HasMany(u => u.Ingredients).WithOne(i => i.User).HasForeignKey(i => i.UserID);
            });

            // Cấu hình khóa ngoại liên quan đến Recipe
            builder.Entity<Recipe>(options =>
            {
                options.HasMany(r => r.Comments).WithOne(c => c.Recipe).HasForeignKey(c => c.RecipeID);
                options.HasMany(r => r.Favorites).WithOne(f => f.Recipe).HasForeignKey(f => f.RecipeID);
                options.HasMany(r => r.Reports).WithOne(r => r.Recipe).HasForeignKey(r =>r.RecipeID);
                options.HasMany(r => r.Recipe_Ingredients).WithOne(ri => ri.Recipe).HasForeignKey(ri => ri.RecipeID);
                options.HasMany(r => r.Recipe_Steps).WithOne(st => st.Recipe).HasForeignKey(st => st.RecipeID);
            });

            // Cấu hình khóa ngoại liên quan đến Ingredient
            builder.Entity<Ingredient>()
                .HasMany(i => i.Recipe_Ingredients)
                .WithOne(ri => ri.Ingredient)
                .HasForeignKey(ri => ri.IngredientID);

            // Cấu hình khóa ngoại liên quan đến Category
            builder.Entity<Category>()
                .HasMany(c => c.Recipes)
                .WithOne(r => r.Category)
                .HasForeignKey(r=>r.CategoryID);

            // Cấu hình các khóa vừa là khóa ngoại vừa là khóa chính

            builder.Entity<Favorite>()
                .HasKey(f=>new {f.UserID, f.RecipeID});

            builder.Entity<Recipe_Ingredient>()
                .HasKey(ei => new { ei.IngredientID, ei.RecipeID });

            builder.Entity<Follow>()
               .HasKey(f => new { f.FollowerID, f.FollowedID });


            builder.Entity<Report>()
               .HasKey(r => new { r.ReporterID, r.RecipeID });
        }
    }
}

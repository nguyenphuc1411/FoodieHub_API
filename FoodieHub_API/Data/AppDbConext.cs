using FoodieHub_API.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FoodieHub_API.Data
{
    public class AppDbConext:IdentityDbContext<ApplicationUser>
    {
        public AppDbConext(DbContextOptions<AppDbConext> options):base(options) { }

        #region DBSET
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<UserFollow> UserFollows { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Recipe_Ingredient> Recipe_Ingredients { get; set; }
        public DbSet<ProcessStep> ProcessSteps { get; set; }
        public DbSet<RecipeReport> RecipeReports { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Cấu hình các thuộc tính khóa

            // Cấu hình khóa ngoại liên quan đến User
            builder.Entity<ApplicationUser>(options =>
            {
                options.HasMany(u => u.Notifications).WithOne(n => n.User).HasForeignKey(n => n.UserID);
                // Khoa ngoai cho bang Follow
                options.HasMany(u => u.Followers).WithOne(f => f.Follower).HasForeignKey(f =>f.FollowerID);
                options.HasMany(u => u.Following).WithOne(f => f.Followed).HasForeignKey(f => f.FollowedID);

                options.HasMany(u => u.Comments).WithOne(c => c.User).HasForeignKey(c => c.UserID);
                options.HasMany(u => u.Favorites).WithOne(f => f.User).HasForeignKey(f => f.UserID);               
                options.HasMany(u => u.Recipes).WithOne(r => r.User).HasForeignKey(r => r.UserID);
                // Khóa ngoại cho bảng Report
                options.HasMany(u => u.Reporters).WithOne(r => r.Reporter).HasForeignKey(r => r.ReporterID);
                options.HasMany(u => u.Handlers).WithOne(r => r.Handler).HasForeignKey(r => r.HandlerID);

                options.HasMany(u => u.Ingredients).WithOne(i => i.User).HasForeignKey(i => i.UserID);
            });

            // Cấu hình khóa ngoại liên quan đến Recipe
            builder.Entity<Recipe>(options =>
            {
                options.HasMany(r => r.Comments).WithOne(c => c.Recipe).HasForeignKey(c => c.RecipeID);
                options.HasMany(r => r.Favorites).WithOne(f => f.Recipe).HasForeignKey(f => f.RecipeID);
                options.HasMany(r => r.RecipeReports).WithOne(r => r.Recipe).HasForeignKey(r =>r.RecipeID);
                options.HasMany(r => r.Recipe_Ingredients).WithOne(ri => ri.Recipe).HasForeignKey(ri => ri.RecipeID);
                options.HasMany(r => r.ProcessSteps).WithOne(st => st.Recipe).HasForeignKey(st => st.RecipeID);
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

            builder.Entity<UserFollow>()
               .HasKey(f => new { f.FollowerID, f.FollowedID });


            builder.Entity<RecipeReport>()
               .HasKey(r => new { r.ReporterID, r.RecipeID });

            // Cấu hình tất cả Foreign Key DeleteBehavior là NoAction

            foreach (var foreignKey in builder.Model.GetEntityTypes().SelectMany(x=>x.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.NoAction;
            }


            // Dữ liệu mặc định cho AspNetUsers

            var hasher = new PasswordHasher<ApplicationUser>();

            var adminUser = new ApplicationUser
            {
                Id = "a1111111-bbbb-cccc-dddd-eeeeeeeeeeee", 
                FullName = "Admin Default",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                Status = "Active", 
                Created_At = DateTime.Now
            };

            // Tạo password hash cho người dùng admin
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "Admin123");

            builder.Entity<ApplicationUser>().HasData(adminUser);
        }
    }
}

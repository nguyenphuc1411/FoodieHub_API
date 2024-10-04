﻿// <auto-generated />
using System;
using FoodieHub_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodieHub_API.Data.Migrations
{
    [DbContext(typeof(AppDbConext))]
    [Migration("20241004143400_initial1")]
    partial class initial1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodieHub_API.Data.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bio")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "a1111111-bbbb-cccc-dddd-eeeeeeeeeeee",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c712e1c3-2d12-469a-a398-389339b61d98",
                            Created_At = new DateTime(2024, 10, 4, 21, 33, 59, 920, DateTimeKind.Local).AddTicks(2018),
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            FullName = "Admin Default",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN123",
                            PasswordHash = "AQAAAAIAAYagAAAAEPsOs0auG5OSetc8Kralvavpn6CLKqJFX9P118r6STtEm+O+04bEJaprXgq3RXQIHg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2dfa7669-392f-4443-b8c2-0d9320298239",
                            Status = "Active",
                            TwoFactorEnabled = false,
                            Updated_At = new DateTime(2024, 10, 4, 21, 33, 59, 920, DateTimeKind.Local).AddTicks(2007),
                            UserName = "Admin123"
                        });
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CategoryID");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentID"));

                    b.Property<string>("ContentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<int>("RecipeID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CommentID");

                    b.HasIndex("RecipeID");

                    b.HasIndex("UserID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Favorite", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RecipeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.HasKey("UserID", "RecipeID");

                    b.HasIndex("RecipeID");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Ingredient", b =>
                {
                    b.Property<int>("IngredientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientID"));

                    b.Property<string>("IngredientName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IngredientID");

                    b.HasIndex("UserID");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Notification", b =>
                {
                    b.Property<int>("NotificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationID"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("NotificationID");

                    b.HasIndex("UserID");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.ProcessStep", b =>
                {
                    b.Property<int>("StepID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StepID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("RecipeID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("StepID");

                    b.HasIndex("RecipeID");

                    b.ToTable("ProcessSteps");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Recipe", b =>
                {
                    b.Property<int>("RecipeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("CookingTime")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsBanned")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Portion")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("Updated_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RecipeID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("UserID");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.RecipeReport", b =>
                {
                    b.Property<string>("ReporterID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RecipeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Handled_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("HandlerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<string>("ReportContext")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReporterID", "RecipeID");

                    b.HasIndex("HandlerID");

                    b.HasIndex("RecipeID");

                    b.ToTable("RecipeReports");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Recipe_Ingredient", b =>
                {
                    b.Property<int>("IngredientID")
                        .HasColumnType("int");

                    b.Property<int>("RecipeID")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IngredientID", "RecipeID");

                    b.HasIndex("RecipeID");

                    b.ToTable("Recipe_Ingredients");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.UserFollow", b =>
                {
                    b.Property<string>("FollowerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FollowedID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.HasKey("FollowerID", "FollowedID");

                    b.HasIndex("FollowedID");

                    b.ToTable("UserFollows");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "3",
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "a1111111-bbbb-cccc-dddd-eeeeeeeeeeee",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Comment", b =>
                {
                    b.HasOne("FoodieHub_API.Data.Entities.Recipe", "Recipe")
                        .WithMany("Comments")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FoodieHub_API.Data.Entities.ApplicationUser", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Favorite", b =>
                {
                    b.HasOne("FoodieHub_API.Data.Entities.Recipe", "Recipe")
                        .WithMany("Favorites")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FoodieHub_API.Data.Entities.ApplicationUser", "User")
                        .WithMany("Favorites")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Ingredient", b =>
                {
                    b.HasOne("FoodieHub_API.Data.Entities.ApplicationUser", "User")
                        .WithMany("Ingredients")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Notification", b =>
                {
                    b.HasOne("FoodieHub_API.Data.Entities.ApplicationUser", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.ProcessStep", b =>
                {
                    b.HasOne("FoodieHub_API.Data.Entities.Recipe", "Recipe")
                        .WithMany("ProcessSteps")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Recipe", b =>
                {
                    b.HasOne("FoodieHub_API.Data.Entities.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FoodieHub_API.Data.Entities.ApplicationUser", "User")
                        .WithMany("Recipes")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.RecipeReport", b =>
                {
                    b.HasOne("FoodieHub_API.Data.Entities.ApplicationUser", "Handler")
                        .WithMany("Handlers")
                        .HasForeignKey("HandlerID")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("FoodieHub_API.Data.Entities.Recipe", "Recipe")
                        .WithMany("RecipeReports")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FoodieHub_API.Data.Entities.ApplicationUser", "Reporter")
                        .WithMany("Reporters")
                        .HasForeignKey("ReporterID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Handler");

                    b.Navigation("Recipe");

                    b.Navigation("Reporter");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Recipe_Ingredient", b =>
                {
                    b.HasOne("FoodieHub_API.Data.Entities.Ingredient", "Ingredient")
                        .WithMany("Recipe_Ingredients")
                        .HasForeignKey("IngredientID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FoodieHub_API.Data.Entities.Recipe", "Recipe")
                        .WithMany("Recipe_Ingredients")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.UserFollow", b =>
                {
                    b.HasOne("FoodieHub_API.Data.Entities.ApplicationUser", "Followed")
                        .WithMany("Following")
                        .HasForeignKey("FollowedID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FoodieHub_API.Data.Entities.ApplicationUser", "Follower")
                        .WithMany("Followers")
                        .HasForeignKey("FollowerID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Followed");

                    b.Navigation("Follower");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FoodieHub_API.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FoodieHub_API.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FoodieHub_API.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FoodieHub_API.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.ApplicationUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Favorites");

                    b.Navigation("Followers");

                    b.Navigation("Following");

                    b.Navigation("Handlers");

                    b.Navigation("Ingredients");

                    b.Navigation("Notifications");

                    b.Navigation("Recipes");

                    b.Navigation("Reporters");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Category", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Ingredient", b =>
                {
                    b.Navigation("Recipe_Ingredients");
                });

            modelBuilder.Entity("FoodieHub_API.Data.Entities.Recipe", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Favorites");

                    b.Navigation("ProcessSteps");

                    b.Navigation("RecipeReports");

                    b.Navigation("Recipe_Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}

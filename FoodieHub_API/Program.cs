using FoodieHub_API.Data;
using FoodieHub_API.Data.Entities;
using FoodieHub_API.Repositories;
using FoodieHub_API.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Cấu hình DbContext với Identity

builder.Services.AddDbContext<AppDbConext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppDb"));
});

builder.Services.AddIdentity<ApplicationUser,IdentityRole>()
    .AddEntityFrameworkStores<AppDbConext>()
        .AddDefaultTokenProviders();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Cấu hình CORS

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowsOrigins",
        policy =>
        {
            policy.WithOrigins("https://example.com", "https://anotherdomain.com") // Chỉ cho phép các nguồn này
                    .AllowAnyHeader()  // Cho phép tất cả các header
                    .AllowAnyMethod(); // Cho phép tất cả method GET POST PUT DELETE
        }
    );
});


// Khai báo các DI

builder.Services.AddScoped<IAuthService, AuthRepository>();

builder.Services.AddScoped<IRecipeService, RecipeRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Cấu hình sử dụng Static Files

app.UseStaticFiles();

// Cấu hình sử dụng middleware kích hoạt CORS

app.UseCors("AllowsOrigins");

// Cấu hình middleware cho xác thực
app.UseAuthentication();

// Cấu hình middleware cho phân quyền
app.UseAuthorization();

app.MapControllers();

app.Run();

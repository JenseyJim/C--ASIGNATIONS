using Microsoft.EntityFrameworkCore;
using ShopApp.DAL.Context;
using ShopApp.DAL.Daos;
using ShopApp.DAL.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ShopContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("ShopContext")));

builder.Services.AddScoped<ICategoriesDb, CategorieDb>();
builder.Services.AddScoped<ICustomersDb, CustomerDb>();
builder.Services.AddScoped<IProducts, ProductDb>();
builder.Services.AddScoped<ISuppliers, SupplierDb>();

builder.Services.AddControllersWithViews();
 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

using Codifico.WebAPI.DataBase;
using Codifico.WebAPI.Interfaces;
using Codifico.WebAPI.Interfaces.Business;
using Codifico.WebAPI.Repository;
using Codifico.WebAPI.Repository.Persistency;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


AddSwagger();
AddControllersViews();
AddDbContext();
AddDependencyInjectionServices();
AddDependencyInjectionRepositorys();
AddHttpDirections();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (!app.Environment.IsDevelopment())
{

}

app.UseStaticFiles();
app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyHeader()
          .AllowAnyMethod());
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");
app.MapFallbackToFile("index.html"); ;
app.Run();











void AddDependencyInjectionServices()
{
    builder.Services.AddScoped< EmployeeServices>();
    builder.Services.AddScoped< ShipperServices>();
    builder.Services.AddScoped< ProductsServices>();
    builder.Services.AddScoped< OrdersServices>();
}

void AddDependencyInjectionRepositorys() 
{

    builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
    builder.Services.AddScoped<IShipperRepository, ShipperRepository>();
    builder.Services.AddScoped<IProductsRepository, ProductsRepository>();
    builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();
}

void AddSwagger()
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

void AddControllersViews()
{
    builder.Services.AddControllersWithViews();
}

void AddDbContext()
{
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
}

void AddHttpDirections()
{
    builder.Services.AddHttpsRedirection(options =>
    {
        options.HttpsPort = 7145;
    });
}


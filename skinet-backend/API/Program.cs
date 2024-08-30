using Microsoft.EntityFrameworkCore;
using skinet.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(opt =>
{
    opt.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), MySqlServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")));
});

var app = builder.Build();

app.MapControllers();

app.Run();

using Microsoft.EntityFrameworkCore;
using TE.Core.Domain;
using TE.Core.Interfaces;
using TE.Core.Services;
using TE.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddScoped<IService<Prestation>, Service<Prestation>>();
builder.Services.AddScoped<IService<Tache>, Service<Tache>>();
builder.Services.AddTransient(typeof(IService<>), typeof(Service<>));
builder.Services.AddDbContext<DbContext, TEContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

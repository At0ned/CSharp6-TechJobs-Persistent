using Microsoft.EntityFrameworkCore;
using TechJobs6Persistent.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "server=localhost;user=techjobs;password=K9l0m15?/;database=tech-jobs";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 37));

builder.Services.AddDbContext<JobDbContext>(DbContextOptions => DbContextOptions.UseMySql(connectionString, serverVersion));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Job}/{action=Index}/{id?}");

app.Run();


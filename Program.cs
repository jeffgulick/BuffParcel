using BuffParcel.Models;
using BuffParcel.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Adds session services needed for login
builder.Services.AddSession();

// Register services
builder.Services.AddScoped<EmailService>();
builder.Services.AddScoped<PackageService>();
builder.Services.AddScoped<ResidentService>();


//Injection of db context
builder.Services.AddDbContext<PackageDbContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("BuffParcelConnection")));

var app = builder.Build();

// Seed Data
using (var scope = app.Services.CreateScope())
{
    SeedData.Initialize(scope.ServiceProvider);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession(); // Use session middleware

app.UseAuthorization();

app.MapRazorPages();

app.Run();

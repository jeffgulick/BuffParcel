using BuffParcel.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//Injection
builder.Services.AddDbContext<PackageDbContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("BuffParcelConnection")));

var app = builder.Build();

// Add email service
builder.Services.AddScoped<EmailService>();

// Seed Data
// using (var scope = app.Services.CreateScope())
// {
//     SeedData.Initialize(scope.ServiceProvider);
// }

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();

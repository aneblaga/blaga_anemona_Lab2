using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using blaga_anemona_Lab2ok.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<blaga_anemona_Lab2okContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("blaga_anemona_Lab2okContext") ?? throw new InvalidOperationException("Connection string 'blaga_anemona_Lab2okContext' not found.")));

var app = builder.Build();

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

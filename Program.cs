using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddControllers();

var app = builder.Build();

app.UseDefaultFiles(); 
app.UseStaticFiles();  


app.MapControllers();


app.MapGet("/index", async context =>
{
    await context.Response.SendFileAsync("wwwroot/index.html");
});

app.Run();

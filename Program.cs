using Microsoft.EntityFrameworkCore;
//using YourNamespace.Data; // Altere para o namespace correto onde está o AppDbContext

var builder = WebApplication.CreateBuilder(args);

// Adiciona o serviço do banco de dados MySQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseDefaultFiles(); // Serve index.html por padrão
app.UseStaticFiles(); // Permite servir arquivos da pasta wwwroot

app.MapGet("/index", async context =>
{
    await context.Response.SendFileAsync("wwwroot/index.html");
});

app.Run();

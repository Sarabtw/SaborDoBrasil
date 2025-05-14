using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Exemplo de DbSet
    public DbSet<Publicacao> Publicacoes { get; set; }
}
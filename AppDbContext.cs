using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Publicacao> Publicacoes { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Comentario> Comentarios { get; set; }
    public DbSet<Like> Likes { get; set; }
}
public class Publicacao
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Imagem { get; set; }
    public string Local { get; set; }
    public string Cidade { get; set; }

  
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }

  
    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();
}

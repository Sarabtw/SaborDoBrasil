public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Imagem { get; set; }
    public string Senha { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public bool Ativo { get; set; } = true;


    public virtual ICollection<Publicacao> Publicacoes { get; set; } = new List<Publicacao>();
    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();
}

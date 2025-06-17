public class Like
{
    public int Id { get; set; }
    public bool Gostou { get; set; } // true = like, false = dislike

    // FK para o usuário que deu like/dislike
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }

    // FK para a publicação curtida
    public int PublicacaoId { get; set; }
    public virtual Publicacao Publicacao { get; set; }
}

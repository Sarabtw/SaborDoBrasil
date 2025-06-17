public class Comentario
{
    public int Id { get; set; }
    public string Texto { get; set; }

    // FK para o usuário que comentou
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }

    // FK para a publicação comentada
    public int PublicacaoId { get; set; }
    public virtual Publicacao Publicacao { get; set; }
}

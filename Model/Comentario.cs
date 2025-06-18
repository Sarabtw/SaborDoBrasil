public class Comentario
{
    public int Id { get; set; }
    public string Texto { get; set; }

   
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }

   
    public int PublicacaoId { get; set; }
    public virtual Publicacao Publicacao { get; set; }
}

public class Comentario
{
    public int Id { get; set; }
    public string Texto { get; set; }
    public string Usuario { get; set; }
    public int PublicacaoId { get; set; }
    public Publicacao Publicacao { get; set; }
}
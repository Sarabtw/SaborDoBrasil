public class Like
{
    public int Id { get; set; }
    public string Usuario { get; set; }
    public int PublicacaoId { get; set; }
    public Publicacao Publicacao { get; set; }
    public bool Gostou { get; set; } // true = like, false = dislike
}
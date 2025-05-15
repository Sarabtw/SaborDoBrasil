public class Publicacao
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Imagem { get; set; }
    public string Local { get; set; }
    public string Cidade { get; set; }

    public ICollection<Publicacao> Publicacoes { get; set; }
}
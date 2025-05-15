public class Publicacao
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public bool Ativo { get; set; } = true;

    // Relacionamento com Publicacao
    public ICollection<Publicacao> Publicacoes { get; set; }


}
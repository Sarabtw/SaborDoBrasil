using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PublicacaoController : ControllerBase
{
    private readonly AppDbContext _context;

    public PublicacaoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> PostPublicacao([FromBody] Publicacao publicacao)
    {
        _context.Publicacoes.Add(publicacao);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(PostPublicacao), new { id = publicacao.Id }, publicacao);
    }
}
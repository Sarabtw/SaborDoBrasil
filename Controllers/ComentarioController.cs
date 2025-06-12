using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ComentarioController : ControllerBase
{
    private readonly AppDbContext _context;

    public ComentarioController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> PostComentario([FromBody] Comentario comentario)
    {
        _context.Comentarios.Add(comentario);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(PostComentario), new { id = comentario.Id }, comentario);
    }
}
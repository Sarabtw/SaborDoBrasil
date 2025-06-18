using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class LikeController : ControllerBase
{
    private readonly AppDbContext _context;

    public LikeController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> PostLike([FromBody] Like like)
    {
        
        _context.Likes.Add(like);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(PostLike), new { id = like.Id }, like);
    }
}
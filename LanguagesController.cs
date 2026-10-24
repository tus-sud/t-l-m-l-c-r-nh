
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PolyLearnAI.Api.Data;

namespace PolyLearnAI.Api.Controllers;

[ApiController]
[Route("api/languages")]
public class LanguagesController : ControllerBase
{
    private readonly PolyLearnDbContext _db;

    public LanguagesController(PolyLearnDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<IActionResult> GetLanguages()
    {
        var languages = await _db.Languages
            .AsNoTracking()
            .OrderBy(x => x.LanguageID)
            .ToListAsync();

        return Ok(languages);
    }
}

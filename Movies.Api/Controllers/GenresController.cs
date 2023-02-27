using Microsoft.AspNetCore.Mvc;
using Movies.Application.Resources.Genres;
using Movies.Application.Services.Genres.Interfaces;
using Movies.Core.Http.Responses;

namespace Movies.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GenresController : Controller
{
    private readonly IGenreService _genreService;

    public GenresController(IGenreService genreService)
    {
        _genreService = genreService;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(List<GenreResponse>))]
    [ProducesResponseType(500, Type = typeof(ErrorResponse))]
    public async Task<IActionResult> GetContacts()
    {
        return Ok(await _genreService.GetGenres());
    }
}
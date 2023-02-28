using Microsoft.AspNetCore.Mvc;
using Movies.Application.Resources.Movies;
using Movies.Application.Services.Movies.Interfaces;
using Movies.Core.Http.Responses;

namespace Movies.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : Controller
{
    private readonly IMovieService _moviesService;

    public MoviesController(IMovieService contactService)
    {
        _moviesService = contactService;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(List<MovieResponse>))]
    [ProducesResponseType(500, Type = typeof(ErrorResponse))]
    public async Task<IActionResult> GetContacts()
    {
        return Ok(await _moviesService.GetAll());
    }

    [HttpGet("{id}")]
    [ProducesResponseType(200, Type = typeof(MovieResponse))]
    [ProducesResponseType(404, Type = typeof(ErrorResponse))]
    [ProducesResponseType(500, Type = typeof(ErrorResponse))]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await _moviesService.GetById(id));
    }

    [HttpPost]
    [ProducesResponseType(201, Type = typeof(int))]
    [ProducesResponseType(400, Type = typeof(ErrorResponse))]
    [ProducesResponseType(500, Type = typeof(ErrorResponse))]
    public async Task<IActionResult> Insert(MovieInsertRequest model)
    {
        return Created("", await _moviesService.Insert(model));
    }

    [HttpPut("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(400, Type = typeof(ErrorResponse))]
    [ProducesResponseType(404, Type = typeof(ErrorResponse))]
    [ProducesResponseType(500, Type = typeof(ErrorResponse))]
    public async Task<IActionResult> UpdateById(int id, MovieUpdateRequest model)
    {
        await _moviesService.UpdateById(id, model);

        return NoContent();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(400, Type = typeof(ErrorResponse))]
    [ProducesResponseType(404, Type = typeof(ErrorResponse))]
    [ProducesResponseType(500, Type = typeof(ErrorResponse))]
    public async Task<IActionResult> Delete(int id)
    {
        await _moviesService.DeleteById(id);

        return NoContent();
    }
}
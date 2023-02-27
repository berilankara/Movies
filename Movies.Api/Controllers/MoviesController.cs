using Microsoft.AspNetCore.Mvc;
using Movies.Application.Services.MovieServices.Interfaces;
using Movies.Application.Services.MovieServices.Resources;

namespace Movies.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController : Controller
{
    private readonly IMovieService _movieService;
    
    public MovieController(IMovieService contactService)
    {
        _movieService = contactService;
    }

    [HttpGet("movies")]
    [ProducesResponseType(200, Type = typeof(List<MovieResponse>))]
    public async Task<IActionResult> GetContacts()
    {
        try
        {
            var result = await _movieService.GetAll();

            return Ok(result);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("movies/{id}")]
    [ProducesResponseType(200, Type = typeof(MovieResponse))]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var result = await _movieService.GetById(id);

            return Ok(result);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPost("movies")]
    [ProducesResponseType(201, Type = typeof(int))]
    public async Task<IActionResult> Insert(MovieInsertRequest model)
    {
        try
        {
            var result = await _movieService.Insert(model);

            return Created("", result);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
    
    [HttpPut("movies/{id}")]
    [ProducesResponseType(204)]
    public async Task<IActionResult> UpdateById(int id,MovieUpdateRequest model)
    {
        try
        {
            await _movieService.UpdateById(id, model);

            return NoContent();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
    
    [HttpDelete("movies/{id}")]
    [ProducesResponseType(204)]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _movieService.DeleteById(id);

            return NoContent();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
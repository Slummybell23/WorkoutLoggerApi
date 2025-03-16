using Microsoft.AspNetCore.Mvc;
using PostgresApiNew.Models;

namespace PostgresApiNew.Controllers;

[ApiController]
[Route("[controller]")]
public class CacheServerPostGresController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<CacheServerPostGresController> _logger;
    private PostGresContext _context;
    public CacheServerPostGresController(ILogger<CacheServerPostGresController> logger, PostGresContext context)
    {
        _context = context;   
        _logger = logger;
    }
    
    [HttpGet("GetWeatherForcast")]
    public IEnumerable<Persons> GetWeatherForcast()
    {
        return Enumerable.Range(1, 5).Select(index => new Persons
            {
            })
            .ToArray();
    }

    [HttpGet("GetHelloWorld")]
    public String GetHelloWorld()
    {
        var obj = _context.WorkoutModel.ToList();
        return "Hello World!";
    }
}
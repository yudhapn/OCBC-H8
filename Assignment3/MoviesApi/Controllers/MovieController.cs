using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MoviesApi.Data;
using MoviesApi.Models;

namespace MoviesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MovieController : ControllerBase
    {
        private readonly MovieDbContext _context;

        public MovieController(MovieDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await _context.Movies.ToListAsync();
            return Ok(movies);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(MovieItem data)
        {
            if (ModelState.IsValid)
            {
                await _context.Movies.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new { data.id }, data);
            }
            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            var item = await _context.Movies.FirstOrDefaultAsync(x => x.id == id);

            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id, MovieItem item)
        {
            if (id != item.id)
            {
                return BadRequest();
            }

            var existItem = await _context.Movies.FirstOrDefaultAsync(x => x.id == id);

            if (existItem == null)
            {
                return NotFound();
            }
            existItem.title = item.title;
            existItem.overview = item.overview;
            existItem.adult = item.adult;
            existItem.voteAverage = item.voteAverage;
            existItem.voteCount = item.voteCount;

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
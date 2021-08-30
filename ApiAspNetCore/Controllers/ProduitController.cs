using ApiAspNetCore.ProduitData;
using Microsoft.AspNetCore.Mvc;

namespace ApiAspNetCore.Controllers
{

    [ApiController]
    public class ProduitController : ControllerBase
    {
        private IProduitData _produitData;
        public ProduitController(IProduitData produitData)
        {
            _produitData = produitData;
        }

        [HttpGet]
        [Route("produits")]
        public IActionResult GetProduits()
        {

            return Ok(_produitData.GetProduits());
        }

        [HttpGet]
        [Route("produits{id}")]
        public IActionResult GetProduit(int id)
        {

            return Ok(_produitData.GetProduit(id));
        }
    }
}












/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using ApiAspNetCore.Model;

namespace ApiAspNetCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProduitController : ControllerBase
    {
        private readonly MoviesDbContext _context;

        public MoviesController(MoviesDbContext context)
        {
            _context = context;
        }

        // GET: api/Movies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        // PUT: api/Movies/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            _context.Entry(movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Movies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie", new { id = movie.Id }, movie);
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Movie>> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return movie;
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}*/


/*
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace ApiAspNetCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProduitController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ProduitController> _logger;

        public ProduitController(ILogger<ProduitController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}







List<Produit> produits = new List<Produit>()
        {
            new Produit() { idProduit = 1, Libelle = "yogourt", Description = "Yogourt frais et bon", PU = 1000, QteStock = 50, DatePeremption = new DateTime()},
        };

        [HttpGet("GetProduits")]
        public IActionResult Get(int id)
        {
            var pr = produits.SingleOrDefault(x => x.idProduit == id);
            if(pr == null)
            {
                return NotFound(value: "Auccun resultat");
            }
            return Ok(pr);
        }

        [HttpPost]
        public IActionResult post(Produit pr)
        {
            produits.Add(pr);
            if(produits.Count == 0)
            {
                return NotFound(value: "la Liste des produits est vide");
            }
            return Ok(produits);
        }

        [HttpDelete]
        public IActionResult delete(int id)
        {
            var pr = produits.SingleOrDefault(x => x.idProduit == id);
            if(pr == null)
            {
                return NotFound(value: "Le produit n'existe pas");
            }
            return Ok(produits);
        }



 */
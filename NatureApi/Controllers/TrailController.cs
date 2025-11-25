using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NatureApi.DTO_s;
using NatureApi.Entities;

namespace NatureApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrailController : ControllerBase
    {
        
        private readonly StoreDbContext _context;
        public TrailController(StoreDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trail>>> GetTrails([FromQuery] string? difficulty, [FromQuery] int? placeId)
        {
            var query = _context.Trail
                .Include(t => t.Place) // Incluye la información del lugar relacionado
                .AsQueryable();

            if (!string.IsNullOrEmpty(difficulty))
            {
                query = query.Where(t => t.Difficulty.ToLower() == difficulty.ToLower());
            }

            if (placeId.HasValue)
            {
                query = query.Where(t => t.PlaceId == placeId);
            }

            var trails = await query.ToListAsync();
            return Ok(trails);
        }

        /// <summary>
        /// Obtiene un sendero específico por su ID.
        /// </summary>
        [HttpGet("{id}")]
        // Cambiamos el tipo de retorno a nuestro nuevo DTO
        public async Task<ActionResult<TrailCDTO>> GetTrailById(int id)
        {
            var trail = await _context.Trail
                .Where(t => t.Id == id)
                // Proyectamos el resultado a TrailDTO
                .Select(t => new TrailCDTO
                {
                    Id = t.Id,
                    Name = t.Name,
                    DistanceKm = t.DistanceKm,
                    EstimatedTimeMinutes = t.EstimatedTimeMinutes,
                    Difficulty = t.Difficulty,
                    Path = t.Path,
                    IsLoop = t.IsLoop,
                    PlaceId = t.PlaceId
                })
                .FirstOrDefaultAsync();

            if (trail == null)
            {
                return NotFound($"No se encontró un sendero con el ID {id}.");
            }

            return Ok(trail);
        }
        
        

    }
}

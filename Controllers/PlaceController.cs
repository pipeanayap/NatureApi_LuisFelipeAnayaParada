using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NatureApi.DTO_s;
using NatureApi.Entities;

namespace NatureApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        
        private readonly StoreDbContext _context;

        public PlaceController(StoreDbContext context)
        {
            _context = context;
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var invoice = await _context.Place
                .Include(p => p.Photos)
                .Include(p => p.Trails)
                .Include(p => p.Reviews)
                .FirstOrDefaultAsync(i => i.Id == id);
            return Ok(invoice);
        }
        
        // NatureApi/Controllers/PlaceController.cs
        [HttpGet]
        public async Task<ActionResult> GetPlaces([FromQuery] string? category, [FromQuery] string? dificulty)
        {
            var query = _context.Place
                .Include(p => p.Trails)
                .Include(p => p.Photos)
                .Include(p => p.Reviews)
                .AsQueryable();

            if (!string.IsNullOrEmpty(category))
                query = query.Where(p => p.Category == category);

            if (!string.IsNullOrEmpty(dificulty))
                query = query.Where(p => p.Trails.Any(t => t.Difficulty == dificulty));

            var places = await query.ToListAsync();
            return Ok(places);
        }
        
        [HttpPost]
        public async Task<ActionResult> CreatePlace([FromBody] PlaceCDTO place)
        {
            var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var newPlace = new Place
                {
                    Name = place.Name,
                    Description = place.Description,
                    Category = place.Category,
                    Latitude = place.Latitude,
                    Longitude = place.Longitude,
                    ElevationMeters = place.ElevationMeters,
                    Accessible = place.Accessible,
                    EntryFee = place.EntryFee,
                    OpeningHours = place.OpeningHours,
                    CreatedAt = DateTime.Now,
                    
                };
                _context.Place.Add(newPlace);
                await _context.SaveChangesAsync();

                var placeAmenities = place.Amenities.Select(ap => new PlaceAmenity()
                {
                    AmenityId = ap, PlaceId = newPlace.Id
                });
                _context.PlaceAmenity.AddRange(placeAmenities);
                await _context.SaveChangesAsync();
                
                await transaction.CommitAsync();
                return Ok(newPlace);
            }
            catch (Exception e)
            {
                // Rollback por si sale mal la transacción
                await transaction.RollbackAsync();
                Console.WriteLine(e);
                throw;
            }
        }
        
        
        

        
        
        
    }
}

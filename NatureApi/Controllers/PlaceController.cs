using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NatureApi.DTO_s;
using NatureApi.Entities;
using OpenAI.Chat;

namespace NatureApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class PlaceController : ControllerBase
    {
        
        private readonly StoreDbContext _context;
        private readonly IConfiguration _config;
        public PlaceController(StoreDbContext context, IConfiguration config)
        {
            _context = context;
            _config =  config;

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
        
        
        [HttpGet("{id}/ai-facts")]
        public async Task<ActionResult> GetPlaceFacts(int id)
        {
            // Obtener el APIKey
            var openAIKey = _config["OpenAIKey"];
            var client = new ChatClient(model: "gpt-4o-mini", apiKey: openAIKey);

            // Obtener datos del lugar con todas sus relaciones
            var place = await _context.Place
                .Include(p => p.Photos)
                .Include(p => p.Trails)
                .Include(p => p.Reviews)
                .Include(p => p.PlaceAmenities)
                .ThenInclude(pa => pa.Amenity)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (place == null)
                return NotFound();

            // Preparar datos para la IA
            var placeData = new
            {
                place.Name,
                place.Description,
                place.Category,
                Latitude = place.Latitude,
                Longitude = place.Longitude,
                place.ElevationMeters,
                PhotosCount = place.Photos.Count,
                TrailsCount = place.Trails.Count,
                Trails = place.Trails.Select(t => new { t.Name, t.Difficulty, t.DistanceKm }),
                Reviews = place.Reviews.Select(r => new { r.Rating, r.Comment }),
                Amenities = place.PlaceAmenities.Select(pa => pa.Amenity.Name)
            };

            var jsonData = System.Text.Json.JsonSerializer.Serialize(placeData);

            // Crear prompt
            var prompt = Prompts.GenerateFacts(jsonData);

            // Llamar a la IA
            var result = await client.CompleteChatAsync(
                [new UserChatMessage(prompt)]);

            var response = result.Value.Content[0].Text;

            return Ok(response);
        }
    }
        
        
        

        
        
        
    }


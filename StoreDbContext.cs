using Microsoft.EntityFrameworkCore;
using NatureApi.Entities;

namespace NatureApi;

public class StoreDbContext : DbContext
{

    public DbSet<Amenity> Amenity { get; set; }
    public DbSet<Photo> Photo { get; set; }
    public DbSet<Place> Place { get; set; }
    public DbSet<PlaceAmenity> PlaceAmenity { get; set; }
    public DbSet<Review> Review { get; set; }
    public DbSet<Trail> Trail { get; set; }

    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
    {
        
    }

    // Seed data completo para el DbContext
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);
    modelBuilder.Entity<PlaceAmenity>().HasKey(p => new { p.PlaceId, p.AmenityId });
    
    
    // Places
    modelBuilder.Entity<Place>().HasData(
        new Place 
        { 
            Id = 1, 
            Name = "Museo del Prado", 
            Description = "Una de las pinacotecas más importantes del mundo, alberga obras maestras de Velázquez, Goya y El Greco",
            Category = "Museo",
            Latitude = 40.4138,
            Longitude = -3.6921,
            ElevationMeters = 655,
            Accessible = true,
            EntryFee = 15.00,
            OpeningHours = "Lunes a sábado 10:00-20:00, Domingos 10:00-19:00",
            CreatedAt = new DateTime(2023, 1, 15)
        },
        new Place 
        { 
            Id = 2, 
            Name = "La Sagrada Familia", 
            Description = "Basílica diseñada por Antoni Gaudí, obra maestra del modernismo catalán aún en construcción",
            Category = "Arquitectura",
            Latitude = 41.4036,
            Longitude = 2.1744,
            ElevationMeters = 152,
            Accessible = true,
            EntryFee = 26.00,
            OpeningHours = "Abril-septiembre 9:00-20:00, Octubre-marzo 9:00-18:00",
            CreatedAt = new DateTime(2023, 2, 10)
        },
        new Place 
        { 
            Id = 3, 
            Name = "Alhambra", 
            Description = "Complejo palaciego y fortaleza nazarí que refleja el arte andalusí en su máximo esplendor",
            Category = "Patrimonio Histórico",
            Latitude = 37.1773,
            Longitude = -3.5986,
            ElevationMeters = 738,
            Accessible = false,
            EntryFee = 19.09,
            OpeningHours = "Octubre-marzo 8:30-18:00, Abril-septiembre 8:30-20:00",
            CreatedAt = new DateTime(2023, 1, 20)
        },
        new Place 
        { 
            Id = 4, 
            Name = "Parque del Retiro", 
            Description = "Histórico parque público de Madrid, perfecto para pasear y relajarse en el corazón de la ciudad",
            Category = "Parque",
            Latitude = 40.4153,
            Longitude = -3.6844,
            ElevationMeters = 650,
            Accessible = true,
            EntryFee = 0.00,
            OpeningHours = "Octubre-marzo 6:00-22:00, Abril-septiembre 6:00-24:00",
            CreatedAt = new DateTime(2023, 3, 5)
        },
        new Place 
        { 
            Id = 5, 
            Name = "Catedral de Sevilla", 
            Description = "La catedral gótica más grande del mundo, alberga la tumba de Cristóbal Colón",
            Category = "Arquitectura Religiosa",
            Latitude = 37.3859,
            Longitude = -5.9933,
            ElevationMeters = 11,
            Accessible = true,
            EntryFee = 12.00,
            OpeningHours = "Lunes a sábado 11:00-17:00, Domingos 14:30-18:00",
            CreatedAt = new DateTime(2023, 2, 28)
        },
        new Place 
        { 
            Id = 6, 
            Name = "Plaza Mayor", 
            Description = "Plaza barroca considerada una de las más bellas de España, centro neurálgico de Salamanca",
            Category = "Plaza Histórica",
            Latitude = 40.9701,
            Longitude = -5.6635,
            ElevationMeters = 802,
            Accessible = true,
            EntryFee = 0.00,
            OpeningHours = "24 horas",
            CreatedAt = new DateTime(2023, 1, 30)
        }
    );

    // Trails
    modelBuilder.Entity<Trail>().HasData(
        new Trail 
        { 
            Id = 1, 
            PlaceId = 3, 
            Name = "Ruta de los Palacios Nazaríes", 
            DistanceKm = 2.5, 
            EstimatedTimeMinutes = 180, 
            Difficulty = "Moderada", 
            Path = "Entrada → Alcazaba → Palacios Nazaríes → Generalife", 
            IsLoop = false 
        },
        new Trail 
        { 
            Id = 2, 
            PlaceId = 4, 
            Name = "Sendero del Estanque", 
            DistanceKm = 3.2, 
            EstimatedTimeMinutes = 90, 
            Difficulty = "Fácil", 
            Path = "Puerta de Alcalá → Estanque → Palacio de Cristal → Rosaleda", 
            IsLoop = true 
        },
        new Trail 
        { 
            Id = 3, 
            PlaceId = 1, 
            Name = "Ruta de las Obras Maestras", 
            DistanceKm = 1.8, 
            EstimatedTimeMinutes = 120, 
            Difficulty = "Fácil", 
            Path = "Velázquez → Goya → El Greco → Rubens", 
            IsLoop = false 
        },
        new Trail 
        { 
            Id = 4, 
            PlaceId = 2, 
            Name = "Tour de las Torres", 
            DistanceKm = 0.8, 
            EstimatedTimeMinutes = 75, 
            Difficulty = "Moderada", 
            Path = "Entrada → Nave → Torres → Museo", 
            IsLoop = false 
        },
        new Trail 
        { 
            Id = 5, 
            PlaceId = 5, 
            Name = "Ruta de la Giralda", 
            DistanceKm = 1.2, 
            EstimatedTimeMinutes = 60, 
            Difficulty = "Moderada", 
            Path = "Catedral → Capilla Mayor → Giralda → Patio de los Naranjos", 
            IsLoop = false 
        },
        new Trail 
        { 
            Id = 6, 
            PlaceId = 6, 
            Name = "Recorrido Histórico", 
            DistanceKm = 2.8, 
            EstimatedTimeMinutes = 45, 
            Difficulty = "Fácil", 
            Path = "Plaza Mayor → Casa de las Conchas → Universidad → Catedral Vieja", 
            IsLoop = true 
        }
    );

    // Photos
    modelBuilder.Entity<Photo>().HasData(
        // Museo del Prado
        new Photo { Id = 1, PlaceId = 1, Url = "https://images.unsplash.com/photo-1578662996442-48f60103fc96" },
        new Photo { Id = 2, PlaceId = 1, Url = "https://images.unsplash.com/photo-1571678264022-e97ed89a33b4" },
        new Photo { Id = 3, PlaceId = 1, Url = "https://images.unsplash.com/photo-1594736797933-d0601ba19be5" },
        
        // La Sagrada Familia
        new Photo { Id = 4, PlaceId = 2, Url = "https://images.unsplash.com/photo-1583422409516-2895a77efded" },
        new Photo { Id = 5, PlaceId = 2, Url = "https://images.unsplash.com/photo-1539650116574-75c0c6d00f2f" },
        new Photo { Id = 6, PlaceId = 2, Url = "https://images.unsplash.com/photo-1511527844068-006b95d162c2" },
        
        // Alhambra
        new Photo { Id = 7, PlaceId = 3, Url = "https://images.unsplash.com/photo-1558642452-9d2a7deb7f62" },
        new Photo { Id = 8, PlaceId = 3, Url = "https://images.unsplash.com/photo-1605282003441-4828c8b69cd3" },
        new Photo { Id = 9, PlaceId = 3, Url = "https://images.unsplash.com/photo-1571663852432-bb0f4e7db0b2" },
        
        // Parque del Retiro
        new Photo { Id = 10, PlaceId = 4, Url = "https://images.unsplash.com/photo-1584464491033-06628f3a6b7b" },
        new Photo { Id = 11, PlaceId = 4, Url = "https://images.unsplash.com/photo-1590075865b93-5b81e33c1321" },
        new Photo { Id = 12, PlaceId = 4, Url = "https://images.unsplash.com/photo-1557804506-669a67965ba0" },
        
        // Catedral de Sevilla
        new Photo { Id = 13, PlaceId = 5, Url = "https://images.unsplash.com/photo-1571663818459-0bcc3c55a49b" },
        new Photo { Id = 14, PlaceId = 5, Url = "https://images.unsplash.com/photo-1633888080670-7c5ad7e6b28d" },
        new Photo { Id = 15, PlaceId = 5, Url = "https://images.unsplash.com/photo-1589900670714-25370142cd17" },
        
        // Plaza Mayor Salamanca
        new Photo { Id = 16, PlaceId = 6, Url = "https://images.unsplash.com/photo-1546600799-4d0a5d5a158a" },
        new Photo { Id = 17, PlaceId = 6, Url = "https://images.unsplash.com/photo-1571663870103-2dd96e4b9c63" },
        new Photo { Id = 18, PlaceId = 6, Url = "https://images.unsplash.com/photo-1506905925346-21bda4d32df4" }
    );

    // Amenities
    modelBuilder.Entity<Amenity>().HasData(
        new Amenity { Id = 1, Name = "WiFi Gratuito" },
        new Amenity { Id = 2, Name = "Estacionamiento" },
        new Amenity { Id = 3, Name = "Acceso para Discapacitados" },
        new Amenity { Id = 4, Name = "Cafetería" },
        new Amenity { Id = 5, Name = "Tienda de Recuerdos" },
        new Amenity { Id = 6, Name = "Audioguía" },
        new Amenity { Id = 7, Name = "Baños Públicos" },
        new Amenity { Id = 8, Name = "Área de Picnic" },
        new Amenity { Id = 9, Name = "Tours Guiados" },
        new Amenity { Id = 10, Name = "Taquillas" },
        new Amenity { Id = 11, Name = "Área Infantil" },
        new Amenity { Id = 12, Name = "Jardines" },
        new Amenity { Id = 13, Name = "Ascensor" },
        new Amenity { Id = 14, Name = "Seguridad 24h" },
        new Amenity { Id = 15, Name = "Información Turística" }
    );

  
    // Place-Amenity Relations (Tabla Pivote)
    modelBuilder.Entity<PlaceAmenity>().HasData(
        // Museo del Prado
        new { PlaceId = 1, AmenityId = 1 },  // WiFi
        new { PlaceId = 1, AmenityId = 3 },  // Accesibilidad
        new { PlaceId = 1, AmenityId = 4 },  // Cafetería
        new { PlaceId = 1, AmenityId = 5 },  // Tienda
        new { PlaceId = 1, AmenityId = 6 },  // Audioguía
        new { PlaceId = 1, AmenityId = 7 },  // Baños
        new { PlaceId = 1, AmenityId = 10 }, // Taquillas
        new { PlaceId = 1, AmenityId = 14 }, // Seguridad
        new { PlaceId = 1, AmenityId = 15 }, // Información
    
        // La Sagrada Familia
        new { PlaceId = 2, AmenityId = 1 },  // WiFi
        new { PlaceId = 2, AmenityId = 3 },  // Accesibilidad
        new { PlaceId = 2, AmenityId = 5 },  // Tienda
        new { PlaceId = 2, AmenityId = 6 },  // Audioguía
        new { PlaceId = 2, AmenityId = 7 },  // Baños
        new { PlaceId = 2, AmenityId = 9 },  // Tours
        new { PlaceId = 2, AmenityId = 13 }, // Ascensor
        new { PlaceId = 2, AmenityId = 14 }, // Seguridad
        new { PlaceId = 2, AmenityId = 15 }, // Información
    
        // Alhambra
        new { PlaceId = 3, AmenityId = 1 },  // WiFi
        new { PlaceId = 3, AmenityId = 2 },  // Estacionamiento
        new { PlaceId = 3, AmenityId = 4 },  // Cafetería
        new { PlaceId = 3, AmenityId = 5 },  // Tienda
        new { PlaceId = 3, AmenityId = 6 },  // Audioguía
        new { PlaceId = 3, AmenityId = 7 },  // Baños
        new { PlaceId = 3, AmenityId = 9 },  // Tours
        new { PlaceId = 3, AmenityId = 12 }, // Jardines
        new { PlaceId = 3, AmenityId = 14 }, // Seguridad
        new { PlaceId = 3, AmenityId = 15 }, // Información
    
        // Parque del Retiro
        new { PlaceId = 4, AmenityId = 1 },  // WiFi
        new { PlaceId = 4, AmenityId = 3 },  // Accesibilidad
        new { PlaceId = 4, AmenityId = 7 },  // Baños
        new { PlaceId = 4, AmenityId = 8 },  // Área de Picnic
        new { PlaceId = 4, AmenityId = 11 }, // Área Infantil
        new { PlaceId = 4, AmenityId = 12 }, // Jardines
        new { PlaceId = 4, AmenityId = 14 }, // Seguridad
        new { PlaceId = 4, AmenityId = 15 }, // Información
    
        // Catedral de Sevilla
        new { PlaceId = 5, AmenityId = 1 },  // WiFi
        new { PlaceId = 5, AmenityId = 3 },  // Accesibilidad
        new { PlaceId = 5, AmenityId = 5 },  // Tienda
        new { PlaceId = 5, AmenityId = 6 },  // Audioguía
        new { PlaceId = 5, AmenityId = 7 },  // Baños
        new { PlaceId = 5, AmenityId = 9 },  // Tours
        new { PlaceId = 5, AmenityId = 14 }, // Seguridad
        new { PlaceId = 5, AmenityId = 15 }, // Información
    
        // Plaza Mayor Salamanca
        new { PlaceId = 6, AmenityId = 1 },  // WiFi
        new { PlaceId = 6, AmenityId = 3 },  // Accesibilidad
        new { PlaceId = 6, AmenityId = 4 },  // Cafetería
        new { PlaceId = 6, AmenityId = 7 },  // Baños
        new { PlaceId = 6, AmenityId = 14 }, // Seguridad
        new { PlaceId = 6, AmenityId = 15 }  // Información
    );
}
    


    
}
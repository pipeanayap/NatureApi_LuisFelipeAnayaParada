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
        new Photo { Id = 1, PlaceId = 1, Url = "https://aws-tiqets-cdn.imgix.net/images/content/91e400c23f0140abb059eb1958530e84.jpg?auto=format%2Ccompress&fit=crop&ixlib=python-4.0.0&q=70" },
        new Photo { Id = 2, PlaceId = 1, Url = "https://content3.cdnprado.net/imagenes/Documentos/imgsem/c9/c928/c9284595-b7c7-ff6b-92bf-b42cbea3ffdb/5612ce87-ade3-78f4-0baa-b9df91dc7269.jpg" },
        new Photo { Id = 3, PlaceId = 1, Url = "https://imagenes.elpais.com/resizer/v2/2PDTE6EQA5G7LFCU7YAOXAD45U.jpg?auth=fd6c8f02f039ef2e06298bb31b3c026ad18cef03b12b9413b866f1fc893bd705&width=414" },
        
        // La Sagrada Familia
        new Photo { Id = 4, PlaceId = 2, Url = "https://images.unsplash.com/photo-1583422409516-2895a77efded" },
        new Photo { Id = 5, PlaceId = 2, Url = "https://media.tacdn.com/media/attractions-splice-spp-674x446/16/15/0b/fc.jpg" },
        new Photo { Id = 6, PlaceId = 2, Url = "https://pro.static.holabarcelonablog.tmb.cat/s3fs-public/2020-12/SF.jpg" },
        
        // Alhambra
        new Photo { Id = 7, PlaceId = 3, Url = "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-674x446/0f/aa/09/d4.jpg" },
        new Photo { Id = 8, PlaceId = 3, Url = "https://cdn-imgix.headout.com/media/images/58da77effa54b9c430bbabfd2a54f135-Alhambra%20Granada.jpeg?auto=format&w=1222.3999999999999&h=687.6&q=90&ar=16%3A9&crop=faces&fit=crop" },
        new Photo { Id = 9, PlaceId = 3, Url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2a/13/de/d1/caption.jpg?w=900&h=500&s=1" },
        
        // Parque del Retiro
        new Photo { Id = 10, PlaceId = 4, Url = "https://anpr.org.mx/wp-content/uploads/2023/03/tomado-de-bekia-viajes-anpr-parque-del-mes-1160x560.png" },
        new Photo { Id = 11, PlaceId = 4, Url = "https://madridpourvous.com/wp-content/uploads/2018/01/Estanque-Grande-Retiro-Madrid.jpg" },
        new Photo { Id = 12, PlaceId = 4, Url = "https://img.nh-hotels.net/8yYbq/rEDOo/original/Spain_Madrid_Retiro.jpg" },
        
        // Catedral de Sevilla
        new Photo { Id = 13, PlaceId = 5, Url = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2f/ff/7b/b5/caption.jpg?w=1200&h=-1&s=1" },
        new Photo { Id = 14, PlaceId = 5, Url = "https://www.lacatedraldesevilla.org/img/catedral-sevilla-1.jpg" },
        new Photo { Id = 15, PlaceId = 5, Url = "https://www.catedraldesevilla.es/wp-content/uploads/2022/11/vista_catedral_exterior.jpg" },
        
        // Plaza Mayor Salamanca
        new Photo { Id = 16, PlaceId = 6, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/90/Salamanca_-_Plaza_Mayor_%2813347610863%29_edited.jpg/1200px-Salamanca_-_Plaza_Mayor_%2813347610863%29_edited.jpg" },
        new Photo { Id = 17, PlaceId = 6, Url = "https://www.turismocastillayleon.com/en/heritage-culture/main-squares/major-square-salamanca.files/267649-hq_Plaza%20Mayor%20de%20Salamanca01_tr.jpg/h,267649-hq_Plaza%20Mayor%20de%20Salamanca01_tr.jpg" },
        new Photo { Id = 18, PlaceId = 6, Url = "https://cdn.getyourguide.com/img/location/56a80a5085eda-wide.jpeg/99.jpg" }
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
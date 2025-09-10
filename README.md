
# NatureApi
---
NatureApi es una API RESTful desarrollada en C# con ASP.NET Core para la gestión de lugares naturales, senderos, fotos, reseñas y amenidades. Permite consultar, crear y administrar información sobre sitios de interés natural.

## Características

- CRUD de lugares (`Place`)
- Gestión de senderos (`Trail`), fotos (`Photo`), reseñas (`Review`) y amenidades (`Amenity`)
- Filtros opcionales por categoría y dificultad
- Validación de coordenadas geográficas
- Relación entre entidades (amenidades, fotos, senderos, reseñas)
- Transacciones seguras al crear lugares y sus amenidades

## Estructura del Proyecto

```
NatureApi/
├── Controllers/
│   └── PlaceController.cs
├── DTO_s/
│   └── PlaceCDTO.cs
├── Entities/
│   ├── Amenity.cs
│   ├── Photo.cs
│   ├── Place.cs
│   ├── PlaceAmenity.cs
│   ├── Review.cs
│   └── Trail.cs
├── Models/
│   └── StoreDbContext.cs
├── Program.cs
└── README.md
```

## Instalación

1. Clona el repositorio:
   ```
   git clone <URL-del-repo>
   ```
2. Abre el proyecto en JetBrains Rider o Visual Studio.
3. Restaura los paquetes NuGet:
   ```
   dotnet restore
   ```
4. Configura la cadena de conexión en `appsettings.json`.
5. Ejecuta las migraciones para crear la base de datos:
   ```
   dotnet ef database update
   ```
6. Inicia la API:
   ```
   dotnet run
   ```

## Uso

La API expone los siguientes endpoints principales:

### Lugares

- **GET /api/places**  
  Lista todos los lugares. Permite filtrar por categoría y dificultad de senderos.
  ```
  /api/places?category=Parque&dificulty=Fácil
  ```

- **GET /api/places/{id}**  
  Obtiene un lugar por su ID, incluyendo fotos, senderos y reseñas.

- **POST /api/places**  
  Crea un nuevo lugar. Valida latitud y longitud.  
  Ejemplo de cuerpo (`PlaceCDTO`):
  ```json
  {
    "name": "Cerro Verde",
    "description": "Parque nacional",
    "category": "Parque",
    "latitude": 13.800,
    "longitude": -89.500,
    "elevationMeters": 2030,
    "accessible": true,
    "entryFee": 5.00,
    "openingHours": "08:00-17:00",
    "amenities": [1, 2, 3]
  }
  ```

### Amenidades, Fotos, Reseñas y Senderos

Gestionados mediante sus respectivos controladores y entidades.

## Entidades Principales

- **Place**: Lugar natural, con propiedades como nombre, descripción, coordenadas, categoría, etc.
- **Trail**: Senderos asociados a un lugar.
- **Photo**: Fotos de un lugar.
- **Review**: Reseñas de usuarios.
- **Amenity**: Amenidades disponibles en el lugar.
- **PlaceAmenity**: Relación entre lugares y amenidades.

## Requisitos

- .NET 6.0 o superior
- SQL Server (o el proveedor configurado)
- JetBrains Rider o Visual Studio

namespace NatureApi.Entities;

public class PlaceAmenity
{
    // Propiedad de Place (revisar como era para la relacion)
    public int PlaceId { get; set; }
    public Place Place { get; set; }
    
    // Propiedad de Amenity (revisar como era para la relacion)
    public int AmenityId { get; set; }
    public Amenity Amenity { get; set; }
    
    
}
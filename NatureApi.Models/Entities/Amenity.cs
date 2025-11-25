namespace NatureApi.Entities;

public class Amenity
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    //Propiedad de navegacion
    public List<PlaceAmenity> PlaceAmenities { get; set; }
}
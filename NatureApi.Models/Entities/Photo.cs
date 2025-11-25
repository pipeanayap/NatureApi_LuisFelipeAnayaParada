namespace NatureApi.Entities;

public class Photo
{
    public int Id { get; set; }
    public string Url { get; set; }
    
    
    // Propiedad de Place (revisar como era para la relacion)
    public int PlaceId { get; set; }
    public Place Place { get; set; }
}
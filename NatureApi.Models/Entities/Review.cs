namespace NatureApi.Entities;

public class Review
{
    public int Id { get; set; }
    public string Author { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime CreatedAt { get; set; }
    
    
    // Propiedad de Place (revisar como era para la relacion)
    public int PlaceId { get; set; }
    public Place Place { get; set; }
}
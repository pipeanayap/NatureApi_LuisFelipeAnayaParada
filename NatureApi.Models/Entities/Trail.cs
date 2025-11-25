namespace NatureApi.Entities;

public class Trail
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double DistanceKm { get; set; }
    public int EstimatedTimeMinutes { get; set; }
    public string Difficulty { get; set; }
    public string Path { get; set; }
    public bool IsLoop { get; set; }
    
    
    
    // Propiedad de Place (revisar como era para la relacion)
    public int PlaceId { get; set; }
    public Place Place { get; set; }
}
namespace LocalRestaurants.Models
{
  public class Cuisine
  {
    public int CuisineId { get; set; }
    public string Type { get; set; }
    public int RestaurantId { get; set; }
  }
}
namespace LocalRestaurants.Models
{
  public class Restaurant
  {

    public int CuisineId { get; set; }
    public Cuisine Cuisine {get; set; }
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    
  }
}
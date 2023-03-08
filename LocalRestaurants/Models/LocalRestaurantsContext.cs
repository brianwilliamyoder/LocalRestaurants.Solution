using Microsoft.EntityFrameworkCore;

namespace LocalRestaurants.Models
{
  public class LocalRestaurantsContext : DbContext
  {
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Cuisine> Cuisines { get; set; }

    public LocalRestaurantsContext(DbContextOptions options) : base(options) { }
  }
}
using Microsoft.EntityFrameCore;

namespace LocalRestaurants.Models
{
  public class LocalRestaurantsContext : DbContext
  {
    public DbSet<Restaurants> Restaurant { get; set; }
    public DbSet<Cuisines> Cuisine { get; set; }

    public LocalRestaurantsContext(DbContextOptions options) : base(options) { }
  }
}
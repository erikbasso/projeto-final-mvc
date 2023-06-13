using Microsoft.EntityFrameworkCore;

namespace miniblogApi.Models
{
public class miniblogApiContext : DbContext
{
  public miniblogApiContext (DbContextOptions<miniblogApiContext> options)
    : base(options)
  {
  }

  public DbSet<Post> Posts { get; set; } = null!;

}
}
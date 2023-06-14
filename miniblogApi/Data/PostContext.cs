using Microsoft.EntityFrameworkCore;

namespace miniblog.Data
{
    public class PostContext : DbContext
    {
      public PostContext (DbContextOptions<PostContext> options)
        : base(options)
      {
      }

      public DbSet<miniblogApi.Models.Post> Post { get; set; }

    }
}
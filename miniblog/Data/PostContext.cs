using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using miniblog.Models;

namespace miniblog.Data
{
     public class PostContext : DbContext
    {
        public PostContext (DbContextOptions<PostContext> options)
            : base(options)
        {
        }

        public DbSet<miniblog.Models.Post> Post { get; set; }
    }
}

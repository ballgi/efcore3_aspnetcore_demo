using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace efcore3_aspnetcore_demo {
    public class BlogContext : DbContext {
        public BlogContext (DbContextOptions<BlogContext> options) : base (options) { }
        
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }


    public class Post
    {

        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; } 
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }

}
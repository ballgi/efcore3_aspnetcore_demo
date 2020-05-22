using System.Collections.Generic;

namespace efcore3_aspnetcore_demo
{
   
    public class Blog
    {
        
        public int BlogID { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        public List<Post> Posts { get; set; }
    }
    
}
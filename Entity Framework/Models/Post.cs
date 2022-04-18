using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework.Models
{
    internal class Post
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public string  Content { get; set; }
        public string  Image { get; set; }
        public List<Post> Posts { get; set; }
    }
}

using MyBlog.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Models
{
    public class Tag : IMyBlogItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}

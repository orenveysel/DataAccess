using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ManyToMany.BlogPostModel
{
    public class Post
    {
        public int Id { get; set; }
        public string Entry { get; set; }
        public List<PostTag> PostTags { get; } = [];
    }
}

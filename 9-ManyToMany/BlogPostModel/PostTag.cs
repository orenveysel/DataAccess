﻿namespace _9_ManyToMany.BlogPostModel
{
    public class PostTag
    {
        public int PostsId { get; set; }
        public int TagsId { get; set; }
        public Post Post { get; set; } = null!;
        public Tag Tag { get; set; } = null!;
    }
}

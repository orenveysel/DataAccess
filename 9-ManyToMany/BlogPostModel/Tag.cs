
namespace _9_ManyToMany.BlogPostModel
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public List<PostTag> PostTags { get; } = [];
    }
}

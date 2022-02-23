namespace Blog.Web.Models
{
    public class PostModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}

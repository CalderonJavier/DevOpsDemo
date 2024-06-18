namespace DevOpsDemo.Models
{
    public class PostViewModel
    {
        public int PostId { get;set; }
        public string Title { get;set; } = string.Empty;
        public string Description { get;set; }
        public string Author { get;set; }
    }
}

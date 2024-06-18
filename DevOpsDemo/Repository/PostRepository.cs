using DevOpsDemo.Models;

namespace DevOpsDemo.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            var post = new List<PostViewModel>()
            {
                new(){ PostId = 101, Title = "DevOps Demo Title 1", Description="DevOps Demo Description 1", Author="Mukesh Kumar"},
                new(){ PostId = 102, Title = "DevOps Demo Title 2", Description="DevOps Demo Description 2", Author="Banky Chamber"},
                new(){ PostId = 103, Title = "DevOps Demo Title 3", Description="DevOps Demo Description 3", Author="Rahul Rathor"},
            };
            return post;
        }
    }
}

using Blog.Web.Models;

namespace Blog.Web.Data
{
    public interface IRepository
    {

        IEnumerable<PostModel> GetAll();

        PostModel? GetPostById(int id);

        void CreatePost(PostModel model);

        void UpdatePost(PostModel model);

        void DeletePost(int id);

        Task<bool> SaveChangesAsync();
    }
}

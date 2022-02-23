using Blog.Web.Models;

namespace Blog.Web.Data
{
    public class Repository : IRepository
    {
        private readonly AppDbContext appDbContext;

        public Repository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void CreatePost(PostModel model)
        {
            this.appDbContext.Posts.Add(model);
        }

        public void DeletePost(int id)
        {
            var postmodel = GetPostById(id);
            if (postmodel != null)
                this.appDbContext.Posts.Remove(postmodel);
        }

        public IEnumerable<PostModel> GetAll()
        {
            return this.appDbContext.Posts.ToList();
        }

        public PostModel? GetPostById(int id)
        {
            return appDbContext.Posts.FirstOrDefault(x => x.Id == id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await this.appDbContext.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }

        public void UpdatePost(PostModel model)
        {
            this.appDbContext.Posts.Update(model);
        }
    }
}

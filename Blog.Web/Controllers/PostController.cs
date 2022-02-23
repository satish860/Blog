using Blog.Web.Data;
using Blog.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly IRepository repository;

        public PostController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult GetAll()
        {
            var posts = this.repository.GetAll();
            return View(posts);
        }

        public IActionResult GetById(int id)
        {
            var post = this.repository.GetPostById(id);
            return View(post);
        }

        [HttpGet]
        public IActionResult ModifyPost(int? id)
        {
            if(id == null)
            {
                return View(new PostModel());
            }
            var post = repository.GetPostById(id.Value);
            return View(post);
        }

        [HttpPost]
        public async Task<IActionResult> ModifyPostAsync(PostModel model)
        {
            if (model.Id > 0)
            {
                this.repository.UpdatePost(model);
            }
            else
                this.repository.CreatePost(model);
            if (await this.repository.SaveChangesAsync())
            {
                return RedirectToAction("GetAll");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            this.repository.DeletePost(id);
            await this.repository.SaveChangesAsync();
            return RedirectToAction("GetAll");
        }

    }
}

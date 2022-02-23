using Blog.Web.Data;
using Blog.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository repository;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }


        public IActionResult Index()
        {
            var posts = this.repository.GetAll();
            return View(posts);
        }

        public IActionResult Post(int Id)
        {
            var post = this.repository.GetPostById(Id);
            return View(post);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return View(new PostModel());
            var post = this.repository.GetPostById(id.Value);
            return View(post);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostModel model)
        {
            if (model.Id > 0)
            {
                this.repository.UpdatePost(model);
            }
            else
                this.repository.CreatePost(model);
            if (await this.repository.SaveChangesAsync())
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            this.repository.DeletePost(id);
            await this.repository.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

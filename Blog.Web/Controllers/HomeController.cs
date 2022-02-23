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

       
    }
}

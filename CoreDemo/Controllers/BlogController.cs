using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class BlogController : Controller
	{
		private BlogManager bm = new BlogManager(new EfBlogReposityory());
		public IActionResult Index()
		{
			var values = bm.GetBlogListWithCategory();
			return View(values);
		}

		public IActionResult BlogReadAll(int id)
		{
			ViewBag.i = id;
			var values = bm.GetBlogById(id);
			return View(values);
		}
	}
}

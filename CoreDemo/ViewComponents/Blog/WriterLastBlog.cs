using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
	public class WriterLastBlog :ViewComponent
	{
		private BlogManager bm = new BlogManager(new EfBlogReposityory());
		public IViewComponentResult Invoke()
		{
			var values = bm.GetBlogListByWriter(2);
			return View(values);
		}
	}
}

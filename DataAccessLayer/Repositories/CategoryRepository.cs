using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
	public class CategoryRepository:ICategoryDal
	{
		private Context c = new Context();
		public List<Category> ListAllCategory()
		{
			return c.Categories.ToList();
		}

		public void AddCategory(Category category)
		{
			c.Add(category);
			c.SaveChanges();
		}

		public void DeleteCategory(Category category)
		{
			c.Remove(category);
			c.SaveChanges();
		}

		public void UpdateCategory(Category category)
		{
			c.Update(category);
			c.SaveChanges();
		}

		public Category GetById(int id)
		{
			return c.Categories.Find(id);
		}
	}
}

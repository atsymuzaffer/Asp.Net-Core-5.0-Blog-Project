using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class CategoryManager:ICategoryService
	{
		EfCategoryRepository efCategoryRepository;

		public CategoryManager()
		{
			efCategoryRepository = new EfCategoryRepository();
		}
		public void CategoryAdd(Category category)
		{
			throw new NotImplementedException();
		}

		public void CategoryDelete(Category category)
		{
			throw new NotImplementedException();

		}

		public void CategoryUpdate(Category category)
		{
			throw new NotImplementedException();
		}

		public List<Category> GetList()
		{
			throw new NotImplementedException();
		}

		public Category GetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}

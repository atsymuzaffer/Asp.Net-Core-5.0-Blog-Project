﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
	public class GenericRepository<T>:IGenericDal<T> where T : class
	{
		public void Insert(T t)
		{
			using var c = new Context();
			c.Add(t);
			c.SaveChanges();
		}

		public void Delete(T t)
		{
			using var c = new Context();
			c.Remove(t);
			c.SaveChanges();
		}

		public void Update(T t)
		{
			using var c = new Context();
			c.Update(t);
			c.SaveChanges();
		}

		public List<T> GetListAll()
		{
			using var c = new Context();
			return c.Set<T>().ToList();
		}

		public T GetById(int id)
		{
			using var c = new Context();
			return c.Set<T>().Find(id);
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{

	public class CommentManager : ICommentService
	{
		private ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void CommentAdd(Comment comment)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetList(int id)
		{

			return _commentDal.GetListAll(x => x.BlogId == id);
			//Yorumu Boş Yorum Olarak Döndürme
			//var Commentvalues = _commentDal.GetListAll(x => x.BlogId == id);
			//if ((!Commentvalues.Any()))
			//{
			//	return Commentvalues;
			//}
			//else
			//{
			//	var commentnull = new List<Comment>
			//	{
			//		new Comment
			//		{
			//			CommentUserName = "Yorum Yok",
			//			CommentContent = "Burada Hiç Yorum Yok İlk Yorumu Sen Yap",
			//		}
			//	};
			//	return commentnull;
			//}
		}
	}
}

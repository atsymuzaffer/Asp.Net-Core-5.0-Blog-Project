﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator:AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez");

			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresi Boş Geçilemez")
				.Matches(@"[@,.]+").WithMessage("Mail adresi @ ve . icermelidir"); ;

			//şifre validation
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez")
				.MinimumLength(8).WithMessage("Şifre 8 karakterden küçük olamaz.")
				.MaximumLength(16).WithMessage("Şifre 16 karakterden büyük olamaz.")
				.Matches(@"[A-Z]+").WithMessage("Şifrede en az bir büyük harf olmalıdır.")
				.Matches(@"[a-z]+").WithMessage("Şifrede en az bir küçük harf olmalıdır.")
				.Matches(@"[0-9]+").WithMessage("Şifrede en az bir rakam olmalıdır");

			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 karakterlik giriş yapabilirsiniz");




		}
	}
}

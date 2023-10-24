using EL.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş geçilemez");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadı boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar adı 2 karakterden az olamaz");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("Yazar soyadı 20 karakterden fazla olamaz");
            RuleFor(x => x.WriterName).Must(y => y!=null && y.Contains("a")).WithMessage("Yazar adında en az 1 adet 'a' karakteri olmalı");
        }
    }
}
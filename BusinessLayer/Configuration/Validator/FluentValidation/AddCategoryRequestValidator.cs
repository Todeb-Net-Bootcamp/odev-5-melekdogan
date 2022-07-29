using DTOs.Category;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Configuration.Validator.FluentValidation
{
    public class AddCategoryRequestValidator : AbstractValidator<AddCategoryRequestDTO>//kategori ekleme isteğinde gelen kategori alanlarını doğrulamadan geçirmek için kullandığım class ve metodu 
    {
        public AddCategoryRequestValidator()
        {
            RuleFor(c => c.CategoryTitle).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez!");
        }
    }
}

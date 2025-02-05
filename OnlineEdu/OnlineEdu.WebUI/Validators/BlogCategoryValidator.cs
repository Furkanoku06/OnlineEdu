using FluentValidation;
using OnlineEdu.WebUI.DTOs.BlogCategoryDTOs;

namespace OnlineEdu.WebUI.Validators
{
    public class BlogCategoryValidator : AbstractValidator<CreateBlogCategoryDTO>
    {
        public BlogCategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Blog Kategori Alanı Boş Bırakılamaz");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Blog Kategori Adı Max 30 karakter olmalıdır");
        }
    }
}

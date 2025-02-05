using FluentValidation;
using OnlineEdu.WebUI.DTOs.BlogDTOs;

namespace OnlineEdu.WebUI.Validators
{
    public class BlogValidator : AbstractValidator<CreateBlogDTO>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Alanı Boş Geçilemez");
            RuleFor(x => x.Title).MaximumLength(100).WithMessage("Başlık Alanı Boş Geçilemez");
        }
    }
}

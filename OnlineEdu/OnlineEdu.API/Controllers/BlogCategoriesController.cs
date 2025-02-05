using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTO_s.BlogCategoryDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController(IGenericService<BlogCategory> _blogCategoryService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _blogCategoryService.TGetList();
            var blogCategory = _mapper.Map<List<ResultBlogCategoryDTO>>(values);
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _blogCategoryService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _blogCategoryService.TDelete(id);
            return Ok("BlogCategory Alanı Silindi");
        }
        [HttpPost]
        public IActionResult Create(CreateBlogCategoryDTO createBlogCategoryDTO)
        {
            var newValue = _mapper.Map<BlogCategory>(createBlogCategoryDTO);
            _blogCategoryService.TCreate(newValue);
            return Ok("Yeni bir blogCategory Alanı Eklendi");
        }
        [HttpPut]
        public IActionResult Update(UpdateBlogCategoryDTO updateBlogCategoryDTO)
        {
            var updateValue = _mapper.Map<BlogCategory>(updateBlogCategoryDTO);
            _blogCategoryService.TUpdate(updateValue);
            return Ok("BlogCategory Alanı Silindi");

        }

    }
}

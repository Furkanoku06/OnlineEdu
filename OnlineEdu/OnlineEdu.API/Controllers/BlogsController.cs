using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTO_s.BlogDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController(IMapper _mapper,IBlogService _blogService) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _blogService.TGetBLogsWithCategories();
            var blogs = _mapper.Map<List<ResultBlogDTO>>(values);
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _blogService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult Create(CreateBlogDTO createBlogDTO)
        {
            var newValue = _mapper.Map<Blog>(createBlogDTO);
            _blogService.TCreate(newValue);
            return Ok("Yeni bir Blog eklendi");
        }
        [HttpPut]
        public IActionResult Update(UpdateBlogDTO updateBlogDTO)
        {
            var updateValue = _mapper.Map<Blog>(updateBlogDTO);
            _blogService.TUpdate(updateValue);
            return Ok("Blog güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _blogService.TDelete(id);
            return Ok("Blog Silindi");
        }
    }
}

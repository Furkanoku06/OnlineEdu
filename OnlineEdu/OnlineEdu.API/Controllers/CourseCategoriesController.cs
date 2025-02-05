using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTO_s.AboutDTOs;
using OnlineEdu.DTO.DTO_s.CourseCategoryDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController(IGenericService<CourseCategory> _courseCategoryService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _courseCategoryService.TGetList();
            var courseCategory = _mapper.Map<List<ResultCourseCategoryDTO>>(values);
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _courseCategoryService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseCategoryService.TDelete(id);
            return Ok("KursKategori alanı silindi");
        }
        [HttpPost]
        public IActionResult Create(CreateCourseCategoryDTO createCourseCategoryDTO)
        {
            var newValue = _mapper.Map<CourseCategory>(createCourseCategoryDTO);
            _courseCategoryService.TCreate(newValue);
            return Ok("Yeni KursKategori alanı oluşturuldu");
        }
        [HttpPut]
        public IActionResult Update(UpdateCourseCategoryDTO updateCourseCategoryDTO)
        {
            var updateValue = _mapper.Map<CourseCategory>(updateCourseCategoryDTO);
            _courseCategoryService.TUpdate(updateValue);
            return Ok("KursKategori alanı güncellendi");
        }
    }
}

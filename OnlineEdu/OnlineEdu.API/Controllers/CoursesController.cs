using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTO_s.AboutDTOs;
using OnlineEdu.DTO.DTO_s.CourseDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(IGenericService<Course> _courseService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _courseService.TGetList();
            var course = _mapper.Map<List<ResultCourseDTO>>(values);
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _courseService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseService.TDelete(id);
            return Ok("Kurs alanı silindi");
        }
        [HttpPost]
        public IActionResult Create(CreateCourseDTO createCourseDTO)
        {
            var newValue = _mapper.Map<Course>(createCourseDTO);
            _courseService.TCreate(newValue);
            return Ok("Yeni kurs alanı oluşturuldu");
        }
        [HttpPut]
        public IActionResult Update(UpdateCourseDTO updateCourseDTO)
        {
            var updateValue = _mapper.Map<Course>(updateCourseDTO);
            _courseService.TUpdate(updateValue);
            return Ok("Kurs alanı güncellendi");
        }
    }
}

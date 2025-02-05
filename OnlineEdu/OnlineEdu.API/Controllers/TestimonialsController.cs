using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTO_s.TestimonialDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(IGenericService<Testimonial> _testimonialService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }
        [HttpPost] 
        public IActionResult Create(CreateTestimonialDTO createTestimonialDTO)
        {
            var newValue = _mapper.Map<Testimonial>(createTestimonialDTO);
            _testimonialService.TCreate(newValue);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut]
        public IActionResult Update(UpdateTestimonialDTO updateTestimonialDTO)
        {
            var updateValue = _mapper.Map<Testimonial>(updateTestimonialDTO);
            _testimonialService.TUpdate(updateValue);
            return Ok("Güncelleme işlemi başarılı");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _testimonialService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");
        }
    }
}

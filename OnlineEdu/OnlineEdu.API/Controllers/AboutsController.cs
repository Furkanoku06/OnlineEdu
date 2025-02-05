using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTO_s.AboutDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IGenericService<About> _aboutService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _aboutService.TGetList();

            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _aboutService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _aboutService.TDelete(id);
            return Ok("Hakkımzda alanı silindi");
        }
        [HttpPost]
        public IActionResult Create(CreateAboutDTO createAboutDTO)
        {
            var newValue = _mapper.Map<About>(createAboutDTO);
            _aboutService.TCreate(newValue);
            return Ok("Yeni hakkımızda alanı oluşturuldu");
        }
        [HttpPut]
        public IActionResult Update(UpdateAboutDTO updateAboutDTO)
        {
            var updateValue = _mapper.Map<About>(updateAboutDTO);
            _aboutService.TUpdate(updateValue);
            return Ok("Hakkımızda alanı güncellendi");
        }
    }
}

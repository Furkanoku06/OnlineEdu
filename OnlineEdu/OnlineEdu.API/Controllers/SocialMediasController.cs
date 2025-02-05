using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTO_s.SocialMedyaDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController(IGenericService<SocialMedia> _socialMediaService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _socialMediaService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _socialMediaService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Create(CreateSocialMediaDTO createSocialMediaDTO)
        {
            var newValue = _mapper.Map<SocialMedia>(createSocialMediaDTO);
            _socialMediaService.TCreate(newValue);
            return Ok("Yeni Sosyal Medya Alanı Eklendi");
        }
        [HttpPut]
        public IActionResult Update(UpdateSocialMediaDTO updateSocialMediaDTO)
        {
            var updateValue = _mapper.Map<SocialMedia>(updateSocialMediaDTO);
            _socialMediaService.TUpdate(updateValue);
            return Ok("Sosyal medya alanı güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _socialMediaService.TDelete(id);
            return Ok("Sosyal Medya Alanı Silindi");
        }

    }
}

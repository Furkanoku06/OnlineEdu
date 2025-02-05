using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTO_s.BannerDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IGenericService<Banner> _bannerService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _bannerService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _bannerService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bannerService.TDelete(id);
            return Ok("Banner alanı silindi");
        }
        [HttpPost]
        public IActionResult Create(CreateBannerDTO createBannerDTO)
        {
            var newValue = _mapper.Map<Banner>(createBannerDTO);
            _bannerService.TCreate(newValue);
            return Ok("Yeni Banner alanı eklendi");
        }
        [HttpPut]
        public IActionResult Update(UpdateBannerDTO updateBannerDTO)
        {
            var updateValue = _mapper.Map<Banner>(updateBannerDTO);
            _bannerService.TUpdate(updateValue);
            return Ok("Banner Alanı güncellendi");
        }

    }
}

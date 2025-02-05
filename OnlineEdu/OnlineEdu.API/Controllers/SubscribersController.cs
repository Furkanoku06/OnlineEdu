using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTO_s.SubscriberDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController(IGenericService<Subscriber> _subscriberService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _subscriberService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _subscriberService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Create(CreateSubscriberDTO createSubscriberDTO)
        {
            var newValue = _mapper.Map<Subscriber>(createSubscriberDTO);
            _subscriberService.TCreate(newValue);
            return Ok("Başarılı");
        }
        [HttpPut]
        public IActionResult Update(UpdateSubscriberDTO updateSubscriberDTO)
        {
            var updateValue = _mapper.Map<Subscriber>(updateSubscriberDTO);
            _subscriberService.TUpdate(updateValue);
            return Ok("Güncelleme işlemi yapıldı");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _subscriberService.TDelete(id);
            return Ok("Silme işlemi yapıldı");
        }
    }
}

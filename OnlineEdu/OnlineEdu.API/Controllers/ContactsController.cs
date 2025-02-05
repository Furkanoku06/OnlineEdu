using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTO_s.ContactDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController(IGenericService<Contact> _contactService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Create(CreateContactDTO createContactDTO)
        {
            var newValue = _mapper.Map<Contact>(createContactDTO);
            _contactService.TCreate(newValue);
            return Ok("Yeni bir iletişim alanı eklendi");
        }
        [HttpPut]
        public IActionResult Update(UpdateContactDTO updateContactDTO)
        {
            var updateValue = _mapper.Map<Contact>(updateContactDTO);
            _contactService.TUpdate(updateValue);
            return Ok("İletişim alanı güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _contactService.TDelete(id);
            return Ok("İletişim Alanı Silindi");
        }
    }
}

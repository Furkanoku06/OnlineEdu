using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTO_s.MessageDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController(IGenericService<Message> _messageService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _messageService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _messageService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Create(CreateMessageDTO createMessageDTO)
        {
            var newValue = _mapper.Map<Message>(createMessageDTO);
            _messageService.TCreate(newValue);
            return Ok("Yeni mesaj bölümü eklendi");
        }
        [HttpPut]
        public IActionResult Update(UpdateMessageDTO updateMessageDTO)
        {
            var updateValue = _mapper.Map<Message>(updateMessageDTO);
            _messageService.TUpdate(updateValue);
            return Ok("Mesaj alanı güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _messageService.TDelete(id);
            return Ok("Mesaj alanı silindi");
        }
    }
}

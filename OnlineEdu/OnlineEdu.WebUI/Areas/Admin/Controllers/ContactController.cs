using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.ContactDTOs;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ContactController : Controller
    {
        private readonly HttpClient _httpClient = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _httpClient.GetFromJsonAsync<List<ResultContactDTO>>("Contacts");
            return View(values);
        }

        public async Task<IActionResult> DeleteContact(int id)
        {
            await _httpClient.DeleteAsync("Contacts/" + id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> CreateContact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDTO createContactDTO)
        {
            await _httpClient.PostAsJsonAsync("Contacts", createContactDTO);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateContact(int id)
        {
            var value = await _httpClient.GetFromJsonAsync<UpdateContactDTO>("Contacts/" + id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateContact(UpdateContactDTO updateContactDTO)
        {
            await _httpClient.PutAsJsonAsync("Contacts", updateContactDTO);
            return RedirectToAction("Index");
        }
    }
}

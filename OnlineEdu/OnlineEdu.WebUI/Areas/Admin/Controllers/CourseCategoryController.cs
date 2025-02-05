using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.CourseCategoryDTOs;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class CourseCategoryController : Controller
    {
        private readonly HttpClient _httpClient = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _httpClient.GetFromJsonAsync<List<ResultCourseCategoryDTO>>("CourseCategories");
            return View(values);
        }
        public async Task<IActionResult> DeleteCourseCategory(int id)
        {
            await _httpClient.DeleteAsync("CourseCategories/" +id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> CreateCourseCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCourseCategory(CreateCourseCategoryDTO createCourseCategoryDTO)
        {
            await _httpClient.PostAsJsonAsync("CourseCategories", createCourseCategoryDTO);
            return RedirectToAction("Index");
        }
        
        public async Task<IActionResult> UpdateCourseCategory(int id)
        {
            var value = await _httpClient.GetFromJsonAsync<UpdateCourseCategoryDTO>("CourseCategories/" +id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCourseCategory(UpdateCourseCategoryDTO updateCourseCategoryDTO)
        {
            await _httpClient.PutAsJsonAsync("CourseCategories", updateCourseCategoryDTO);
            return RedirectToAction("Index");
        }
    }
}

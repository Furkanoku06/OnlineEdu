using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineEdu.WebUI.DTOs.BlogCategoryDTOs;
using OnlineEdu.WebUI.DTOs.BlogDTOs;
using OnlineEdu.WebUI.Helpers;
using OnlineEdu.WebUI.Validators;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BlogController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task CategoryDropdown()
        {
            var categoryList = await _client.GetFromJsonAsync<List<ResultBlogCategoryDTO>>("blogCategories");
            List<SelectListItem> categories = (from item in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = item.Name,
                                                   Value = item.BlogCategoryId.ToString()
                                               }).ToList();
            ViewBag.categories = categories;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultBlogDTO>>("blogs");
            return View(values);
        }
        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _client.DeleteAsync($"blogs/{id}");
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> CreateBlog()
        {
            await CategoryDropdown();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogDTO createBlogDTO)
        {
            var validator = new BlogValidator();
            var result = await validator.ValidateAsync(createBlogDTO);
            if (!result.IsValid)
            {
                ModelState.Clear();
                foreach (var x in result.Errors)
                {
                    ModelState.AddModelError(x.PropertyName,x.ErrorMessage);
                }
            }
            await _client.PostAsJsonAsync("blogs", createBlogDTO);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateBlog(int id)
        {
            await CategoryDropdown();
            var value = await _client.GetFromJsonAsync<UpdateBlogDTO>($"blogs/{id}");
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBlog(UpdateBlogDTO updateBlogDTO)
        {
            await _client.PutAsJsonAsync("blogs",updateBlogDTO);
            return RedirectToAction(nameof(Index));
        }

    }
}

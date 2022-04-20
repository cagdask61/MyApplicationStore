using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApplicationStore.Application.Repositories.CategoryRepositories;

namespace MyApplicationStore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryReadRepository _categoryReadRepository;

        public CategoriesController(ICategoryReadRepository categoryReadRepository)
        {
            _categoryReadRepository = categoryReadRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _categoryReadRepository.GetAll();
            return Ok(result);
        }
    }
}

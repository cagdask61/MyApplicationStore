using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApplicationStore.Application.Repositories.CategoryRepositories;
using MyApplicationStore.Domain.Entitites.Concrete;

namespace MyApplicationStore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;

        public CategoriesController(ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var result = _categoryReadRepository.GetAll();
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            _categoryWriteRepository.Add(category);
           var result = _categoryWriteRepository.Save();
            return Ok(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Category category)
        {
            _categoryWriteRepository.Update(category);
            var result = _categoryWriteRepository.Save();
            return Ok(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Category category)
        {
            _categoryWriteRepository.Delete(category);
            var result = _categoryWriteRepository.Save();
            return Ok(result);
        }
    }
}

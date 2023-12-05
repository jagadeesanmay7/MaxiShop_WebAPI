using MaxiShop.Domain.Models;
using MaxiShop.Infrastructure.DbContexts;
using Microsoft.AspNetCore.Mvc;

namespace MaxiShop.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public IActionResult Create([FromBody] Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _dbContext.category.Add(category);
            _dbContext.SaveChanges();
            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public IActionResult Get()
        {
            List<Category> categories = _dbContext.category.ToList();
            return Ok(categories);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        [Route("Details")]
        public IActionResult Get(int id)
        {
            Category categories = _dbContext.category.FirstOrDefault(x => x.Id == id);
            if(categories == null)
            {
                return NotFound($"Category not found for Id - {id}");
            }
            return Ok(categories);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        public IActionResult Update([FromBody] Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _dbContext.category.Update(category);
            _dbContext.SaveChanges();
            return NoContent();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var category = _dbContext.category.First(x => x.Id == id);
            if(category == null)
            {
                return NotFound();
            }
            else
            {
                _dbContext.category.Remove(category);
                _dbContext.SaveChanges();
                return NoContent();
            }
            
        }
    }
}

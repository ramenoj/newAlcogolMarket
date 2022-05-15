using Microsoft.AspNetCore.Mvc;
using newAlcogolMarket.Manager;
using newAlcogolMarket.Models;
using newAlcogolMarket.Models.Alcogol;

namespace newAlcogolMarket.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryManager _manager;
        public CategoriesController(ICategoryManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        [Route("categories")]
        public async Task<IList<CategoryofAlcogol>> GetAll()=>await _manager.GetAll();
        [HttpPut]
        [Route("categories")]
        public Task Create([FromBody] CreateCategoryRequest request) => _manager.Create(request.Name);
    }
}

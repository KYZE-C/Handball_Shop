using Handball_Shopv1.Server.Services.Category_Services_srv;
using Handball_Shopv1.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Handball_Shopv1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory_Service_srv _category_service_srv;

        public CategoryController(ICategory_Service_srv category_Service)
        {
            _category_service_srv = category_Service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            var categories = await _category_service_srv.GetCategories();
            return Ok(categories);
        }
    }
}


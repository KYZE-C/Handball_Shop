using Handball_Shopv1.Server.Services.Product_Services_srv;
using Handball_Shopv1.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Handball_Shopv1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProducts_Service_srv _Products_Service;

        public ProductsController(IProducts_Service_srv products_Service)
        {
            _Products_Service = products_Service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() 
        {
            return Ok(await _Products_Service.GetProducts());
        }
        [HttpGet("Category/{CategoryURL}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(string CategoryURL)
        {
            return Ok(await _Products_Service.GetProductsByCategory(CategoryURL));
        }
        [HttpGet("SP/{Id}")]
        public async Task<ActionResult<Product>> GetSingleProduct(int? Id)
        {
            var product = await _Products_Service.GetSingleProduct(Id);
            if (product != null)
            {
                return Ok(product);
            }           
            else return BadRequest("Product not found.");
        }
    }
}

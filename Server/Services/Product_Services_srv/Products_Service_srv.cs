using Handball_Shopv1.Server.Data;
using Handball_Shopv1.Server.Services.Category_Services_srv;
using Handball_Shopv1.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace Handball_Shopv1.Server.Services.Product_Services_srv
{
    public class Products_Service_srv : IProducts_Service_srv
    {
        private readonly ICategory_Service_srv _category_service_srv;
        private readonly Data_ctx _datacontext;

        public Products_Service_srv(ICategory_Service_srv category_Service_Srv, Data_ctx context )
        {
            _category_service_srv = category_Service_Srv;
            _datacontext = context;
        }
        public async Task<List<Product>> GetProducts()
        {
            return await _datacontext.Products.Include(p => p.Variants).ToListAsync();
        }   

        public async Task<List<Product>> GetProductsByCategory(string CategoryURL)
        {
            Category category = await _category_service_srv.GetCategorybyURL(CategoryURL);
            return await _datacontext.Products.Include(v => v.Variants).Where(p => p.CategoryId == category.Id).ToListAsync();
        }

        public async Task<Product> GetSingleProduct(int? Id)
        {
            Product product = await _datacontext.Products.Include(c => c.Variants).ThenInclude(n => n.Addition).FirstOrDefaultAsync(p => p.Id == Id);
            if (product != null)
            {
                return product;
            }
            else
            {
                return null;
            }
        }
    }
}

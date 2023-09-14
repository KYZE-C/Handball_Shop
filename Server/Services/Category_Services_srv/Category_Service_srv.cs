using Handball_Shopv1.Server.Data;
using Handball_Shopv1.Shared;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Handball_Shopv1.Server.Services.Category_Services_srv
{
    public class Category_Service_srv : ICategory_Service_srv
    {
        private readonly Data_ctx _ctx;

        public Category_Service_srv(Data_ctx datacontext)
        {
            _ctx = datacontext;
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _ctx.Categories.ToListAsync();
        }

        public async Task<Category> GetCategorybyURL(string CategoryURL)
        {
            var category = await _ctx.Categories.FirstOrDefaultAsync(p => p.Url.ToLower().Equals(CategoryURL.ToLower()));
            if (category != null)
            {
                return category;
            }
            else
            {
                string message = "Null refrence by Category returned";
                throw new Exception(message);
            }
        }
    }
}

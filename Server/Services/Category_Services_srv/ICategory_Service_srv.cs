using Handball_Shopv1.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Handball_Shopv1.Server.Services.Category_Services_srv
{
    public interface ICategory_Service_srv
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategorybyURL(string CategoryURL);
    }
}

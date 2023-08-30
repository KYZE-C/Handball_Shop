using Handball_Shopv1.Shared;
using System.Net.Http.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using Handball_Shopv1.Client.Services.Product_Service;

namespace Handball_Shopv1.Client.Services.Category_Service
{
    public class Category_Service : ICategory_Service
    {
        private readonly HttpClient _http;
        public List<Category> Categories { get; set; }

        public Category_Service(HttpClient http)
        {
            _http = http;
        }
        public async Task LoadCategories()
        {
            Categories = await _http.GetFromJsonAsync<List<Category>>("api/Category");
        }
    }
}

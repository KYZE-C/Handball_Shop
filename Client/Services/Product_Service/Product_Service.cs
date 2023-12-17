using Handball_Shopv1.Shared;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace Handball_Shopv1.Client.Services.Product_Service
{
    public class Product_Service : IProducts_Service
    {
        public event Action OnChange;

        private readonly HttpClient _http;

        public List<Product> Products { get; set; } = new List<Product>();//list is filled when shop page is initialized

        public Product_Service(HttpClient http)
        {
            _http = http;
        }
        public async Task LoadProducts(string CategoryURL = null)
        {
            if (CategoryURL == null)
            {
                Products = await _http.GetFromJsonAsync<List<Product>>("api/Products");
            }
            else
            {
                Products = await _http.GetFromJsonAsync<List<Product>>($"api/Products/Category/{CategoryURL}");
            }
            
            OnChange.Invoke();
        }

        public async Task<Product> LoadSingleProduct(int? Id)
        {
            var product = await _http.GetFromJsonAsync<Product>($"api/Products/SP/{Id}");
            if (product != null)
            {
                return product;
            }
            else
            {
                throw new Exception();
            }    
        }
    }
}

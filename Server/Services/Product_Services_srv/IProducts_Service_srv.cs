using Handball_Shopv1.Shared;

namespace Handball_Shopv1.Server.Services.Product_Services_srv
{
    public interface IProducts_Service_srv
    {
        Task<List<Product>> GetProducts();
        Task<List<Product>> GetProductsByCategory(string CategoryURL);
        Task<Product> GetSingleProduct(int? Id);
    }
}

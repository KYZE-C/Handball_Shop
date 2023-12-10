using Handball_Shopv1.Shared;
using Handball_Shopv1.Client.Services.Product_Service;

namespace Handball_Shopv1.Client.Services.Product_Service
{
    public interface IProducts_Service
    {
        event Action OnChange;

		List<Product> filteredproducts { get; set; }
		List<Product> Products { get; set; }

        Task LoadProducts(string CategoryURL = null);

        Task<Product> LoadSingleProduct(int? Id);
    }
}

using Handball_Shopv1.Shared;
using System.Collections;

namespace Handball_Shopv1.Client.Services.Cart_Service
{
    public interface ICart_Service
    {
        event Action Onchange;
        Task AddToCart(Variants_Product product_variant);
        Task DeleteItem(Cart_Item Item);
        Task<List<Cart_Item>> GetCart_Items();
    }
}

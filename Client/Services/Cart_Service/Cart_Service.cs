using Blazored.LocalStorage;
using Blazored.Toast.Services;
using Handball_Shopv1.Client.Pages;
using Handball_Shopv1.Client.Services.Product_Service;
using Handball_Shopv1.Shared;


namespace Handball_Shopv1.Client.Services.Cart_Service
{
    public class Cart_Service : ICart_Service
    {
        private readonly ILocalStorageService _localstorage;
        private readonly IToastService _toastservice;
        private readonly IProducts_Service _productservice;

        public event Action Onchange;

        public Cart_Service(ILocalStorageService LocalStorage, IToastService ToastService, IProducts_Service Products_Service)
        {
            _localstorage = LocalStorage;
            _toastservice = ToastService;
            _productservice = Products_Service;
        }
        public async Task AddToCart(Variants_Product product_variant)
        {
            List<Variants_Product> Cart = await _localstorage.GetItemAsync<List<Variants_Product>>("cart");
            if (Cart == null)
            {
                Cart = new();
            }

            Cart.Add(product_variant);
            await _localstorage.SetItemAsync("cart", Cart);

            var product = await _productservice.LoadSingleProduct(product_variant.ProductId);
            _toastservice.ShowSuccess($"Added To Cart : {product.Title}");

            Onchange.Invoke();
        }

        public async Task<List<Cart_Item>> GetCart_Items()
        {
            List<Cart_Item> result = new List<Cart_Item>();
            List<Variants_Product> Cart = await _localstorage.GetItemAsync<List<Variants_Product>>("cart");

            if (Cart == null) { return result; }
            else
            {
                foreach (var Item in Cart)
                {
                    Product product = await _productservice.LoadSingleProduct(Item.ProductId);
                    Cart_Item cart_item = new()
                    {
                        ProductId = product.Id,
                        Product_Title = product.Title,
                        Product_Image = product.Image,
                        AdditionId = Item.AdditionId,

                    };
                    var variant = product.Variants.Find(v => v.AdditionId == Item.AdditionId);
                    if (variant != null)
                    {
                        cart_item.Addition_Name = variant.Addition.Name;
                        cart_item.Price = variant.Price;
                    }
                    result.Add(cart_item);

                }
                return result;
            }
        }

        public async Task DeleteItem(Cart_Item Item)
        {
            List<Variants_Product> Cart = await _localstorage.GetItemAsync<List<Variants_Product>>("cart");
            if (Cart == null) { return; }
            var Cartitem = Cart.Find(x => x.ProductId == Item.ProductId && x.AdditionId == Item.AdditionId);
            Cart.Remove(Cartitem);

            await _localstorage.SetItemAsync("cart", Cart);
            Onchange.Invoke();
        }
    }
}

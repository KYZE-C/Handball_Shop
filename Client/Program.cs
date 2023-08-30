using Blazored.LocalStorage;
using Blazored.Toast;
using Handball_Shopv1.Client;
using Handball_Shopv1.Client.Services.Cart_Service;
using Handball_Shopv1.Client.Services.Category_Service;
using Handball_Shopv1.Client.Services.Product_Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Handball_Shopv1.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<IProducts_Service, Product_Service>();
            builder.Services.AddScoped<ICategory_Service, Category_Service>();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredToast();
            builder.Services.AddScoped<ICart_Service, Cart_Service>();

            await builder.Build().RunAsync();
        }
    }
}
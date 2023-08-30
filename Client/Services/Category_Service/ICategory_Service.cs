using Handball_Shopv1.Shared;

namespace Handball_Shopv1.Client.Services.Category_Service
{
    public interface ICategory_Service
    {
        List<Category> Categories { get; set; }
        Task LoadCategories();
    }
}

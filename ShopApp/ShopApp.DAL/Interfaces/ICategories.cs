
using ShopApp.DAL.Models.Categories;
using ShopApp.DAL.Models.Customers;

namespace ShopApp.DAL.Interfaces
{
    public interface ICategoriesDb
    {

        List<CategoriesModel> GetCategories();
        CategoriesModel GetCategories(int CategoryId);
        void SaveCategories(CategoriesAddModel categoriesAdd);
        void UpdateCategories(CategoriesUpdateModel categoriesUpdate);
        void DeleteCategories(CategoriesRemoveModel categoriesRemove);




    }
}

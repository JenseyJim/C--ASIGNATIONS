using ShopApp.DAL.Context;
using ShopApp.DAL.Entities;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Categories;


namespace ShopApp.DAL.Daos
{
    public class CategorieDb : ICategoriesDb
    {
        private readonly ShopContext context;

        public CategorieDb(ShopContext context)
        {
            this.context = context;
        }
        public void DeleteCategories(CategoriesRemoveModel categoriesRemove)
        {
            if (categoriesRemove == null || categoriesRemove.categoryid <= 0)
                throw new ArgumentException("Category ID Invalido");

            var category = context.Categories.Find(categoriesRemove.categoryid);
            if (category == null)
                throw new KeyNotFoundException("Category no encontrada");

            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public List<CategoriesModel> GetCategories()
        {

            return context.Categories
            .Select(c => new CategoriesModel
            {
                categoryid = c.categoryid,
                categoryname = c.categoryname,
                description = c.description
            })
            .ToList();
        }

        public CategoriesModel GetCategories(int categoryid)
        {
            if (categoryid <= 0)
                throw new ArgumentException("Category ID Invalido");

            var category = context.Categories.Find(categoryid);
            if (category == null)
                throw new KeyNotFoundException("Category no encontrada");

            return new CategoriesModel
            {
                categoryid = category.categoryid,
                categoryname = category.categoryname,
                description = category.description
            };
        }

        public void SaveCategories(CategoriesAddModel categoriesAdd)
        {
            if (categoriesAdd == null)
                throw new ArgumentException("Categories no acepta v nulos");

            if (string.IsNullOrWhiteSpace(categoriesAdd.categoryname) ||
                string.IsNullOrWhiteSpace(categoriesAdd.description))
            {
                throw new ArgumentException("El nombre y la descripción de la categoría son obligatorios.");
            }

            var newCategory = new Categories
            {
                categoryname = categoriesAdd.categoryname,
                description = categoriesAdd.description,
                creation_date = categoriesAdd.creation_date,
                creation_user = categoriesAdd.creation_user
            };

            context.Categories.Add(newCategory);
            context.SaveChanges();
        }



        public void UpdateCategories(CategoriesUpdateModel categoriesUpdate)
        {
            if (categoriesUpdate == null || categoriesUpdate.categoryid <= 0)
                throw new ArgumentException("Category ID Invalido");

            var category = context.Categories.Find(categoriesUpdate.categoryid);
            if (category == null)
                throw new KeyNotFoundException("Category no encontrada");

            category.categoryname = categoriesUpdate.categoryname;
            category.description = categoriesUpdate.description;

            context.SaveChanges();
        }


    }
}

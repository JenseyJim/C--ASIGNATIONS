using ShopApp.DAL.Models.Customers;
using ShopApp.DAL.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Interfaces
{
    public interface IProducts
    {
        List<ProductsModel> GetProducts();
        ProductsModel GetProducts(int productid);
        void SaveProducts(ProductsAddModel productsAdd);
        void UpdateProducts(ProductsUpdateModel productsUpdate);
        void RemoveProducts(ProductsRemoveModel productsRemove);







    }
}

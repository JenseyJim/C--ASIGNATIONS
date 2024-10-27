using ShopApp.DAL.Models.Products;
using ShopApp.DAL.Models.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Interfaces
{
    public interface ISuppliers
    {
        List<SuppliersModel> GetSuppliers();
        SuppliersModel GetSuppliers(int supplierid);
        void SaveSuppliers(SuppliersAddModel suppliersAdd);
        void UpdateSuppliers(SuppliersUpdateModel suppliersUpdate);
        void RemoveSuppliers(SuppliersRemoveModel suppliersRemove);

    }
}

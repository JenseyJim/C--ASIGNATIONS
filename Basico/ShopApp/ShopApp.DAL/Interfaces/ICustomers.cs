using ShopApp.DAL.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Interfaces
{
    public interface ICustomersDb
    {
        List<CustomersModel> GetCustomers();
        CustomersModel GetCustomers(int custid);
        void SaveCustomers(CustomersAddModel customersAdd);
        void UpdateCustomers(CustomersUpdateModel customersUpdate);
        void RemoveCustomers(CustomersRemoveModel customersRemove);


    }
}

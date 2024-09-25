using ShopApp.DAL.Models.BaseModels;

namespace ShopApp.DAL.Models.Customers
{
    public class CustomersAddModel : CustomersBaseModel
    {
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
    }
}

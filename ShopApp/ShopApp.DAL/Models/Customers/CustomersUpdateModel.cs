using ShopApp.DAL.Models.BaseModels;

namespace ShopApp.DAL.Models.Customers
{
    public class CustomersUpdateModel : CustomersBaseModel
    {
        public int custid { get; set; }
        public DateTime modify_date { get; set; }
        public int modify_user { get; set; }
    }
}

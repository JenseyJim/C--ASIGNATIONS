using ShopApp.DAL.Models.BaseModels;
using System;
using System.Collections.Generic;

namespace ShopApp.DAL.Models.Customers
{
    public class CustomersModel : CustomersBaseModel
    {
        public int custid { get; set; }
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
    }
}

using ShopApp.DAL.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Models.Suppliers
{
    public class SuppliersUpdateModel : SuppliersBaseModel
    {
        public int supplierid { get; set; }
        public DateTime modify_date { get; set; }
        public int modify_user { get; set; }
    }
}

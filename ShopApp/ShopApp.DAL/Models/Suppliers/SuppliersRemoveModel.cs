using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Models.Suppliers
{
    public class SuppliersRemoveModel
    {
        public int supplierid { get; set; }
        public int delete_user { get; set; }
        public DateTime delete_date { get; set; }
    }
}

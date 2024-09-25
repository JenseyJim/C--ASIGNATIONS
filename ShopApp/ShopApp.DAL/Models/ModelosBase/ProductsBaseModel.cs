using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Models.BaseModels
{
    public class ProductsBaseModel
    {
        public string? ProductName { get; set; }
        public int? supplierid { get; set; }
        public int? categoryid { get; set; }
        public decimal? UnitPrice { get; set; }
        public bool? Discontinued { get; set; }
    }
}

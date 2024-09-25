using ShopApp.DAL.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Entities
{
    public class Products : BaseEntity
    {
        [Key]
        public int productid { get; set; }
        public string? ProductName { get; set; }
        public int? supplierid { get; set; }
        public int? categoryid { get; set; }
        public decimal? UnitPrice { get; set; }
        public bool? Discontinued { get; set; }


    }
}

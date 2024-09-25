using ShopApp.DAL.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Entities
{
    public class Suppliers : Contact_Details
    {
        [Key]
        public int supplierid { get; set; }

    }
}

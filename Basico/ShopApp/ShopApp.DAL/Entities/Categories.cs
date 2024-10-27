using ShopApp.DAL.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Entities
{
    public class Categories : BaseEntity
    {
        [Key]
        public int categoryid { get; set; }
        public string? categoryname { get; set; }
        public string? description { get; set; }
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }



    }
}

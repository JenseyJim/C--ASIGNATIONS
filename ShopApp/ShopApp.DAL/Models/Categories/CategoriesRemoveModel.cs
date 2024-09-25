using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Models.Categories
{
    public class CategoriesRemoveModel
    {
        public int categoryid { get; set; }
        public int creation_user { get; set; }
        public DateTime delete_date { get; set; }
    }
}

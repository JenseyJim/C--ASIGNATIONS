using ShopApp.DAL.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Models.Categories
{
    public class CategoriesAddModel : CategoriesBaseModel
    {
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }

    }
}

using ShopApp.DAL.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.DAL.Entities
{
    public class Customers : Contact_Details
    {
        [Key]
        public int custid { get; set; }
        public string? Email { get; set; }

    }
}

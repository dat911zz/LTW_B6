using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2001202045_VuNgoDat_Buoi6.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Name { get; set; }

        public Brand(int id, string productName, string name)
        {
            Id = id;
            ProductName = productName;
            Name = name;
        }
    }
}
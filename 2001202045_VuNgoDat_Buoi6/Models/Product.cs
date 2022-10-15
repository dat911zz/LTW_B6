using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _2001202045_VuNgoDat_Buoi6.Models
{
    public class Product
    {
        [Display(Name = "Mã Điện Thoại")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }
        public float Cost { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }

        public Product(int id, string name, string filePath, float cost, string description, int typeId)
        {
            Id = id;
            Name = name;
            FilePath = filePath;
            Cost = cost;
            Description = description;
            TypeId = typeId;
        }
    }
}
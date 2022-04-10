using _04102022.Models.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04102022.Models
{
    public class MenuItem
    {
        public string No { get; set; } 
        public string Name { get; set; }
        public double Price { get; set; }   
        public CatagoryEnum Catagory { get;set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _04102022.Models.Enum
{
    internal class Order
    {
        private static int _no;
        public int No { get; }
       public  List<Order> OrderItems { get; set; }
        public int TotalAmount { get; set; }
        public DateTime Date { get; set; }  
        public Order()
        {
            _no++;
            No = _no;
        }
    }
}

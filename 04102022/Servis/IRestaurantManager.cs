using _04102022.Models;
using _04102022.Models.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04102022.Servis
{
    internal interface IRestaurantManager
    {
        List<Menu> MenuItems { get; set; }
        List<Order> Orders { get; set; }
       

        public void AddOrder(Order order);
        public void RemoveOrder(int no);
        public List<Order> GetOrdersByDatesInterval(DateTime fromDate, DateTime toDate);
        public List<Order> GetOrdersByDate(DateTime date);
        public List<Order> GetOrdersByPriceInterval(double minPrice, double maxPrice);
        public Order GetOrderByNo(int no);
        public void AddMenuItem(CatagoryEnum category, string name, double price);
        public void RemoveMenuItem(string no);
        public void EditMenuItem(string no, string newName, double newPrice);
        public List<MenuItem> GetMenuItemsByCategory(CatagoryEnum category);
        public List<MenuItem> GetMenuItemsByPricesInterval(double minPrice, double maxPrice);
        public List<MenuItem> GetMenuItemsByNameOrByNo(string name, string no);
    }
}

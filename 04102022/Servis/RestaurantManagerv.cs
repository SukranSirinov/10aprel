using _04102022.Models;
using _04102022.Models.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04102022.Servis
{
    internal class RestaurantManagerv : IRestaurantManager
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public List<Order> Orders { get; set; } = new List<Order>();
        List<Menu> IRestaurantManager.MenuItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<MenuItem> GetMenuItemsByPricesInterval(double minPrice, double maxPrice)
        {
            List<MenuItem> newMenuItems;

            newMenuItems = MenuItems.FindAll(menuItem => menuItem.Price > minPrice && menuItem.Price < maxPrice);

            return newMenuItems;
        }

        public List<Order> GetOrdersByDate(DateTime date)
        {
            List<Order> newOrders;

            newOrders = Orders.FindAll(order => order.Date == date);
            return newOrders;


        }

        public Order GetOrderByNo(int no)
        {
            Order newOrder;
            newOrder = Orders.Find(order => order.No == no);
            if (newOrder == null)
            {
                return null;
            }
            return newOrder;

        }

        public List<Order> GetOrdersByDatesInterval(DateTime fromDate, DateTime toDate)
        {
            List<Order> newOrders;

            newOrders = Orders.FindAll(order => order.Date > fromDate && order.Date < toDate);
            return newOrders;
        }

        public List<Order> GetOrdersByPriceInterval(double minPrice, double maxPrice)
        {
            List<Order> newOrders = Orders.FindAll(order => order.TotalAmount > minPrice && order.TotalAmount < maxPrice);
            return newOrders;
        }

        public void RemoveMenuItem(string no)
        {
            MenuItem newMenuItem = MenuItems.Find(menuItem => menuItem.No == no);
            if (newMenuItem != null)
            {
                MenuItems.Remove(newMenuItem);
            }
        }

        public void RemoveOrder(int no)
        {
            Order newOrder = Orders.Find(order => order.No == no);
            if (newOrder != null)
            {
                Orders.Add(newOrder);
            }
        }

        public void AddOrder(Order order)
        {
            if (order != null)
            {
                Orders.Add(order);
            }
            else
            {
                throw new NullReferenceException(" Null deyer daxil edilib");
            }
        }

        public void AddMenuItem(CatagoryEnum category, string name, double price)
        {
            throw new NotImplementedException();
        }

        public void EditMenuItem(string no, string newName, double newPrice)
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> GetMenuItemsByCategory(CatagoryEnum category)
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> GetMenuItemsByNameOrByNo(string name, string no)
        {
            throw new NotImplementedException();
        }
    }
}

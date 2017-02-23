using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodTruck
{
    public class Order
    {
        

        public int id { get; set; }
        public string client { get; set; }
        public string product { get; set; }
        public int amount { get; set; }
        public int price { get; set; }
        public DateTime date { get; set; }

        public Order(int id, string client, string product, int amount, int price, DateTime date)
        {
            this.id = id;
            this.client = client;
            this.product = product;
            this.amount = amount;
            this.price = price;
            this.date = date;
        }
        public Order(string client, string product, int amount, int price, DateTime date)
        {
            this.client = client;
            this.product = product;
            this.amount = amount;
            this.price = price;
            this.date = date;
        }

    }
}
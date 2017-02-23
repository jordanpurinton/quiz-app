using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodTruck
{

    public class FoodClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public string image { get; set; }

        public string type { get; set; }



        public FoodClass(int id, string name, string description, int price, string image, string type)
        {

            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.image = image;
            this.type = type;
        }

        public FoodClass(string name, string description, int price, string image, string type)
        {

            
            this.name = name;
            this.description = description;
            this.price = price;
            this.image = image;
            this.type = type;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodTruck
{
    public class User
    {
        

        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string type { get; set; }

        public User(int id, string name, string email, string password, string type)
        {
            Id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.type = type;
        }
        public User(string name, string email, string password, string type)
        {
            
            this.name = name;
            this.email = email;
            this.password = password;
            this.type = type;
        }
     
    }
    
}
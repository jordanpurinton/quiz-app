using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FoodTruck
{
    public static class ConnectionClass
    {
        private static SqlConnection conn;
        private static SqlCommand command;

        static ConnectionClass()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TruckConnection"].ToString();
            conn = new SqlConnection(connectionString);
            command = new SqlCommand("", conn);
        }
        public static ArrayList GetFoodByType(string foodType)
        {
            
            ArrayList list = new ArrayList();
            string query = string.Format("SELECT * FROM Product WHERE type LIKE \'{0}\'", foodType);

            try
            {
                conn.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string description = reader.GetString(2);
                    int price = reader.GetInt32(3);
                    string image = reader.GetString(4);
                    string type = reader.GetString(5);

                    FoodClass food = new FoodClass(id, name, description, price, image, type);
                    list.Add(food);
                }
            }
            finally
            {
                conn.Close();
            }
            return list;
        }
        public static FoodClass GetFoodByID(int id)
        {
            
            FoodClass food = null;

            try
            {
                string query = String.Format("SELECT * FROM Product WHERE id =  '{0}'", id);
                conn.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                    string name = reader.GetString(1);
                    string description = reader.GetString(2);
                    int price = reader.GetInt32(3);
                    string image = reader.GetString(4);
                    string type = reader.GetString(5);
                    food = new FoodClass(name, description, price, image, type);
                }
            }
            finally
            {
                conn.Close();
            }
            return food;
        }
        public static void AddFoodItem(FoodClass food)
        
        {
            string query = string.Format(
                "INSERT INTO Product VALUES ('{0}', '{1}', @price, '{2}','{3}')", food.name, food.description, food.image, food.type);
           
            command.CommandText = query;
            command.Parameters.Add(new SqlParameter("price", food.price));
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
                command.Parameters.Clear();
            }
           
        }
        public static User LoginUser(string name, string pass)
        {
            string query = string.Format("SELECT COUNT(*) FROM Users WHERE name = '{0}'", name);
            command.CommandText = query;

            try
            {
                conn.Open();
                int numUsers = (int) command.ExecuteScalar();
                if (numUsers == 1)
                {
                    query = string.Format("SELECT password FROM Users WHERE name = '{0}'", name);
                    command.CommandText = query;
                    string dbpassword = command.ExecuteScalar().ToString();
                    if (dbpassword == pass)
                    {
                        query = string.Format("SELECT email, type FROM Users WHERE name = '{0}'", name);
                        command.CommandText = query;
                        SqlDataReader reader = command.ExecuteReader();
                        User user = null;
                        while (reader.Read()){
                            string email = reader.GetString(0);
                            string type = reader.GetString(1);

                            user = new User(name, email, pass, type);

                        }
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            finally
            {
                conn.Close();
            }
        }
        public static string RegisterUser(User user)
        {
            string query = string.Format("SELECT COUNT(*) FROM Users WHERE name = '{0}'", user.name);
            command.CommandText = query;

            try
            {
                conn.Open();
                int numUsers = (int)command.ExecuteScalar();
                if(numUsers < 1)
                {
                    query = string.Format("INSERT INTO Users VALUES('{0}', '{1}', '{2}', '{3}')", user.name, user.email, user.password, user.type);
                    command.CommandText = query;
                    //command.ExecuteNonQuery();
                    return "Registered!";
                }
                else
                {
                    return "Already registered";
                }
            }
            finally
            {
                conn.Close();
            }
        }
        public static void AddOrder(ArrayList orders)
        {
            try
            {
                command.CommandText = "INSERT INTO Orders VALUES (@client, @product, @amount, @price, @date)";
                conn.Open();
                foreach (Order order in orders)
                {
                    command.Parameters.Add(new SqlParameter("@client", order.client));
                    command.Parameters.Add(new SqlParameter("@product", order.product));
                    command.Parameters.Add(new SqlParameter("@amount", order.amount));
                    command.Parameters.Add(new SqlParameter("@price", order.price));
                    command.Parameters.Add(new SqlParameter("@date", order.date));
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();


                }
            }
            finally
            {
                conn.Close();
            }
        }        
    }

        
}
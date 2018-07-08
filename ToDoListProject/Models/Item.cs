using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ToDoListProject;

namespace ToDoListProject.Models
{
    public class Item
    {
        private int _id;
        private string _description;

        public Item(string Description, int Id = 0)
        {
            _id = Id;
            _description = Description;
        }

        public Item(string description)
        {
            _description = description; 
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }

        public int GetId()
        {
            return _id;
        }

        public static List<Item> GetAll()
        {
            List<Item> allItems = new List<Item> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM items;";
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
                int itemId = rdr.GetInt32(0);
                string itemDescription = rdr.GetString(1);
                Item newItem = new Item(itemDescription, itemId);
                allItems.Add(newItem);
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allItems;
        }
    }
}

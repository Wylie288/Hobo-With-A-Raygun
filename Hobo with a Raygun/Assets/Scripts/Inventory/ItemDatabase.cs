using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour 
{
    static public List<Item> items = new List<Item>();

   static public Item GetItem(int id)
    {
         BuildDatabase();
        return items.Find(item=> item.id == id);
    }

    static public Item GetItem(string itemName)
    {
         BuildDatabase();
        return items.Find(item => item.title == itemName);
    }

    static void BuildDatabase()
    {
        items = new List<Item>() 
        {
            new Item(0, "Empty", "empty",
            new Dictionary<string, int> 
            {
                {"count", 1}
            }),
            new Item(1, "Primarium", "A primarium fragment",
            new Dictionary<string, int> 
            {
                {"count", 1}
            }),
            new Item(2, "Secondite", "A secondite fragment",
            new Dictionary<string, int> 
            {
                {"count", 1}
            }),
            new Item(3, "Tertiarous", "A tertiarous fragment",
            new Dictionary<string, int> 
            {
                {"count", 1}
            }),
            new Item(4, "Quaternum", "A quaternum fragment",
            new Dictionary<string, int> 
            {
                {"count", 1}
            }),
            new Item(5, "GunA", "",
            new Dictionary<string, int> 
            {
                {"shots", 20}
            }),
            new Item(6, "GunB", "",
            new Dictionary<string, int> 
            {
                {"shots", 40}
            }),
            new Item(7, "GunC", "",
            new Dictionary<string, int> 
            {
                {"shots", 80}
            }),
            new Item(8, "HealthA", "",
            new Dictionary<string, int> 
            {
                {"health", 20}
            }),
            new Item(9, "HealthB", "",
            new Dictionary<string, int> 
            {
                {"health", 40}
            }),
            new Item(10, "HealthC", "",
            new Dictionary<string, int> 
            {
                {"health", 80}
            }),
            new Item(11, "Mine1A", "",
            new Dictionary<string, int> 
            {
                {"mine", 8}
            }),
            new Item(12, "Mine1B", "",
            new Dictionary<string, int> 
            {
                {"mine", 14}
            }),
            new Item(13, "Mine1C", "",
            new Dictionary<string, int> 
            {
                {"mine", 17}
            }),
            new Item(14, "Mine2A", "",
            new Dictionary<string, int> 
            {
                {"mine", 8}
            }),
            new Item(15, "Mine2B", "",
            new Dictionary<string, int> 
            {
                {"mine", 14}
            }),
            new Item(16, "Mine2C", "",
            new Dictionary<string, int> 
            {
                {"mine", 17}
            }),
            new Item(100, "F00", "",
            new Dictionary<string, int> 
            {
                {"C", 0},
                {"P", 0},
            }),
            new Item(110, "F10", "",
            new Dictionary<string, int> 
            {
                {"C", 1},
                {"P", 0},
            }),
            new Item(101, "F01", "",
            new Dictionary<string, int> 
            {
                {"C", 0},
                {"P", 1},
            }),
            new Item(111, "F11", "",
            new Dictionary<string, int> 
            {
                {"C", 1},
                {"P", 1},
            }),
            new Item(122, "F22", "",
            new Dictionary<string, int> 
            {
                {"C", 2},
                {"P", 2},
            }),
        };
    }
}

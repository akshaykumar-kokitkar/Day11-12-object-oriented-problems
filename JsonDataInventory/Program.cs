using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonDataInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to JSON data inventory management");
            Console.WriteLine("-----------------------------------------------");
            InventoryData inventoryData = new InventoryData();
        }
    }
}
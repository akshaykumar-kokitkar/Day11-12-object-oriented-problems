using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonDataInventory
{
    class Library
    {
        public string Name;
        public double Weight; 
        public double Price;
        
        public  Library(string Name, double Weight, double Price)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Price = Price;
        }
    }
}

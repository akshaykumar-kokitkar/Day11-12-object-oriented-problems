using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonDataInventory
{
    class InventoryData
    {
        public InventoryData()
        {
            int customerOption;
            Console.WriteLine("Choose one option to perform action: ");
            Console.WriteLine("Choose 1 to add details");
            Console.WriteLine("Choose 2 to display details");
            customerOption = Convert.ToInt32(Console.ReadLine());

            switch (customerOption)
            {


                case 1:
                    List<Library> inventoryList = new List<Library>();

                    Library inventory1 = new Library("Rice", 200, 80);
                    Library inventory2 = new Library("Pulses", 400, 70);
                    Library inventory3 = new Library("Wheats", 700, 60);
                   

                    inventoryList.Add(inventory1);
                    inventoryList.Add(inventory2);
                    inventoryList.Add(inventory3);

                    string json = JsonConvert.SerializeObject(inventoryList);
                    File.WriteAllText(@"DataInventoryFile.json", json);
                    Console.WriteLine("Data Stored");
                    break;

                case 2:

                    Console.WriteLine("Dispaly Inventory Items");
                    Console.WriteLine("---------------------------------------------------");


                    string datafile = File.ReadAllText(@"DataInventoryFile.json");
                    List<Library> returnDataObj = JsonConvert.DeserializeObject<List<Library>>(datafile);
                    

                    foreach (var form in returnDataObj)
                    {
                        Console.WriteLine("Name : " + form.Name);
                        Console.WriteLine("Weight : " + form.Weight);
                        Console.WriteLine("Price : " + form.Price);

                        Console.WriteLine("Total Value of {0} =  {1}: ", form.Name, (form.Weight * form.Price));
                        Console.WriteLine("------------------------------------------------");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Input !");
                    break;
            }
        }

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InventoryManagement
{
    class Inventory
    {
        public static void ReadInput()
        {
            //creating the object for inventory manager class
            InventoryManager manager = new InventoryManager();
            //getting file path of the JSON file
            string filePath = @"C:\Users\wsffa\c#_projects\InventoryManagement\Inventory.json";

            //deserializing the json onject and reading the test from file
            InventoryUtility inventoryUtility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(filePath));
            Console.WriteLine("Display\n1. Rice\n2. Pulse\n3.Wheat");

            //getting the option from the user
            int choice = Convert.ToInt32(Console.ReadLine());

            //calls the method for the particular option
            switch (choice)
            {
                case 1:
                    manager.DisplayInventory(inventoryUtility.riceList);
                    break;

                case 2:
                    manager.DisplayInventory(inventoryUtility.pulseList);
                    break;

                case 3:
                    manager.DisplayInventory(inventoryUtility.wheatList);
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;

            }
        }
    }
}

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
            Console.WriteLine("\n1.Display \n2. Add Inventory\n3. Update Inventory\n4. Delete an Inventory");
            Console.WriteLine("Enter your chioce:");
            //getting the option from the user for operation
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Inventory:");
            //getting input from user for which inventory
            Console.WriteLine("\n1.RICE \n2.PULSES\n3.WHEAT");
            int inventory = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    //calls the method for the particular option
                    switch (inventory)
                    {
                        case 1:
                            Console.WriteLine("======DISPLAYING RICE INVENTORY=======");
                            manager.DisplayInventory(inventoryUtility.riceList);
                            break;

                        case 2:
                            Console.WriteLine("======DISPLAYING PULSE INVENTORY=======");
                            manager.DisplayInventory(inventoryUtility.pulseList);
                            break;

                        case 3:
                            Console.WriteLine("======DISPLAYING WHEAT INVENTORY=======");
                            manager.DisplayInventory(inventoryUtility.wheatList);
                            break;

                        default:
                            Console.WriteLine("Invalid Option");
                            break;

                    }
                    break;

                //selection for adding the item to inventory
                case 2:
                    switch (inventory)
                    {
                        case 1:
                            Console.WriteLine("=========ADDING to RICE INVENTORY========");
                            inventoryUtility.riceList = manager.AddToInventory(inventoryUtility.riceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(inventoryUtility));
                            break;
                        case 2:
                            Console.WriteLine("=========ADDING to PULSE INVENTORY========");
                            inventoryUtility.pulseList = manager.AddToInventory(inventoryUtility.pulseList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(inventoryUtility));
                            break;
                        case 3:
                            Console.WriteLine("=========ADDING to WHEAT INVENTORY========");
                            inventoryUtility.wheatList = manager.AddToInventory(inventoryUtility.wheatList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(inventoryUtility));
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                    Console.WriteLine("Inventory is updated");
                    break;
                //selection for updating the inventory
                case 3:
                    switch (inventory)
                    {
                        case 1:
                            inventoryUtility.riceList = manager.UpdateInventory(inventoryUtility.riceList);
                            inventoryUtility.riceList = manager.AddToInventory(inventoryUtility.riceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(inventoryUtility));
                            break;
                        case 2:
                            inventoryUtility.pulseList = manager.UpdateInventory(inventoryUtility.pulseList);
                            inventoryUtility.pulseList = manager.AddToInventory(inventoryUtility.pulseList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(inventoryUtility));
                            break;
                        case 3:
                            inventoryUtility.wheatList = manager.UpdateInventory(inventoryUtility.wheatList);
                            inventoryUtility.wheatList = manager.AddToInventory(inventoryUtility.wheatList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(inventoryUtility));
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;

                    }
                    Console.WriteLine("Inventory Updated");
                    break;

                //selection for deleting the inventory
                case 4:
                    switch (inventory)
                    {
                        case 1:
                            manager.RemoveInventory(inventoryUtility.riceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(inventoryUtility));
                            break;
                        case 2:
                            manager.RemoveInventory(inventoryUtility.pulseList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(inventoryUtility));
                            break;
                        case 3:
                            manager.RemoveInventory(inventoryUtility.wheatList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(inventoryUtility));
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                    Console.WriteLine("Inventory Deleted");
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

        }
    }
}

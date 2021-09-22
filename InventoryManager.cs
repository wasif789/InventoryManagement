using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    class InventoryManager
    {
        //method to add item to rice inventory
        public List<InventoryUtility.Rice> AddToInventory(List<InventoryUtility.Rice> riceList)
        {
            //create the new object for rice class 
            InventoryUtility.Rice rice = new InventoryUtility.Rice();
            Console.WriteLine("Enter the name of rice:");
            rice.Name = Console.ReadLine();
            Console.WriteLine("Enter the weight of rice in kg:");
            rice.Weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price of the rice:");
            rice.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the type of rice:");
            rice.type = Console.ReadLine();
            //append the updated object to the list
            riceList.Add(rice);
            return riceList;
        }

        //method to add item to pulse inventory
        public List<InventoryUtility.Pulse> AddToInventory(List<InventoryUtility.Pulse> pulseList)
        {
            //create the new object for pulse class 
            InventoryUtility.Pulse pulse = new InventoryUtility.Pulse();
            Console.WriteLine("Enter the name of pulse:");
            pulse.Name = Console.ReadLine();
            Console.WriteLine("Enter the weight of pulse in kg:");
            pulse.Weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price of the pulse:");
            pulse.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the type of pulse:");
            pulse.type = Console.ReadLine();
            //append the updated object to the list
            pulseList.Add(pulse);
            return pulseList;
        }

        //method to add item to wheat inventory
        public List<InventoryUtility.Wheat> AddToInventory(List<InventoryUtility.Wheat> wheatList)
        {
            //create the new object for wheat class 
            InventoryUtility.Wheat wheat = new InventoryUtility.Wheat();
            Console.WriteLine("Enter the name of wheat:");
            wheat.Name = Console.ReadLine();
            Console.WriteLine("Enter the weight of wheat in kg:");
            wheat.Weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the wheat of the rice:");
            wheat.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the wheat of rice:");
            wheat.type = Console.ReadLine();
            //append the updated object to the list
            wheatList.Add(wheat);
            return wheatList;
        }

        //method to update the rice inventory
        public List<InventoryUtility.Rice> UpdateInventory(List<InventoryUtility.Rice> riceList)
        {
            Console.WriteLine("Enter the name of rice to be updated:");
            string Name = Console.ReadLine();
            riceList.Remove(riceList.Find(utl => utl.Name.Equals(Name)));
            return (riceList);
        }

        //method to update the Pulse inventory
        public List<InventoryUtility.Pulse> UpdateInventory(List<InventoryUtility.Pulse> pulseList)
        {
            Console.WriteLine("Enter the name of pulse to be updated:");
            string Name = Console.ReadLine();
            pulseList.Remove(pulseList.Find(utl => utl.Name.Equals(Name)));
            return (pulseList);
        }

        //method to update the Wheat inventory
        public List<InventoryUtility.Wheat> UpdateInventory(List<InventoryUtility.Wheat> wheatList)
        {
            Console.WriteLine("Enter the name of wheat to be updated:");
            string Name = Console.ReadLine();
            wheatList.Remove(wheatList.Find(utl => utl.Name.Equals(Name)));
            return (wheatList);
        }

        //method to delete the rice inventory
        public List<InventoryUtility.Rice> RemoveInventory(List<InventoryUtility.Rice> riceList)
        {
            Console.WriteLine("Enter the name of rice to be Removed:");
            string Name = Console.ReadLine();
            riceList.Remove(riceList.Find(utl => utl.Name.Equals(Name)));
            return (riceList);
        }

        //method to delete the Pulse inventory
        public List<InventoryUtility.Pulse> RemoveInventory(List<InventoryUtility.Pulse> pulseList)
        {
            Console.WriteLine("Enter the name of pulse to be Removed:");
            string Name = Console.ReadLine();
            pulseList.Remove(pulseList.Find(utl => utl.Name.Equals(Name)));
            return (pulseList);
        }

        //method to delete the Wheat inventory
        public List<InventoryUtility.Wheat> RemoveInventory(List<InventoryUtility.Wheat> wheatList)
        {
            Console.WriteLine("Enter the name of wheat to be Removed:");
            string Name = Console.ReadLine();
            wheatList.Remove(wheatList.Find(utl => utl.Name.Equals(Name)));
            return (wheatList);
        }
        //method to display the rice list
        public void DisplayInventory(List<InventoryUtility.Rice> rice)
        {
            string item = string.Empty;
            int totalInvestment = 0;
            //iterate the rice inventory using InventoryUtility.Rice type
            foreach (InventoryUtility.Rice i in rice)
            {
                item = "name:" + i.Name + "\nWeight:" + i.Weight + "\nPrice:" + i.Price + "\nType:" + i.type;
                Console.WriteLine(item);
                totalInvestment += CalculateTotalInvestment(i.Weight, i.Price);
            }
            Console.WriteLine("total investment of rice is:" + totalInvestment);
        }

        //method to display the pulse list
        public void DisplayInventory(List<InventoryUtility.Pulse> pulse)
        {
            string item = string.Empty;
            int totalInvestment = 0;
            //iterate the pulse inventory using InventoryUtility.pulse type
            foreach (InventoryUtility.Pulse i in pulse)
            {
                item = "name: " + i.Name + "\nWeight: " + i.Weight + "\nPrice: " + i.Price + "\nType: " + i.type;
                Console.WriteLine(item);
                totalInvestment += CalculateTotalInvestment(i.Weight, i.Price);
            }
            Console.WriteLine("total investment of pulse is:" + totalInvestment);
        }

        //method to display the wheat list
        public void DisplayInventory(List<InventoryUtility.Wheat> wheat)
        {
            string item = string.Empty;
            int totalInvestment = 0;
            //iterate the wheat inventory using InventoryUtility.Wheat type
            foreach (InventoryUtility.Wheat i in wheat)
            {
                item = "name:" + i.Name + "\nWeight:" + i.Weight + "\nPrice:" + i.Price + "\nType:" + i.type;
                Console.WriteLine(item);
                totalInvestment += CalculateTotalInvestment(i.Weight, i.Price);
            }
            Console.WriteLine("total investment of wheat is:" + totalInvestment);
        }

        //method to calculate the total investment for the inventory
        public int CalculateTotalInvestment(int weight, int price)
        {
            return (weight * price);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    class InventoryManager
    {
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

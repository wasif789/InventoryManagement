using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    class InventoryUtility
    {
        //creating the list for rice inventory
        public List<Rice> riceList { get; set; }

        //creating the list for wheat inventory
        public List<Wheat> wheatList { get; set; }

        //creating the list for pulse inventory
        public List<Pulse> pulseList { get; set; }


        //creating the rice class and create the method to get and set the Name,Weight, price and type
        public class Rice
        {
            //method to get and set name
            public string Name { get; set; }

            //method to get and set Weight
            public int Weight { get; set; }

            //method to get and set price
            public int Price { get; set; }

            //method to get and set type
            public string type { get; set; }

        }
        public class Wheat
        {
            //method to get and set name
            public string Name { get; set; }

            //method to get and set weight
            public int Weight { get; set; }

            //method to get and set price
            public int Price { get; set; }

            //method to get and set type
            public string type { get; set; }

        }
        public class Pulse
        {
            //method to get and set name
            public string Name { get; set; }

            //method to get and set weight
            public int Weight { get; set; }

            //method to get and set price
            public int Price { get; set; }

            //method to get and set type
            public string type { get; set; }

        }
    }
}

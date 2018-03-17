using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> standardItems;

        static ItemFactory()
        {
            // Populate the standardItems list(load from DB or XML file in the future)
            standardItems = new List<GameItem>();

            standardItems.Add(new Weapon(1001, "Pointy Stick", 1, 1, 1));
            standardItems.Add(new Weapon(1002, "Rusty Sword", 5, 1, 2));
            standardItems.Add(new GameItem(9001, "Snake fang", 1));
            standardItems.Add(new GameItem(9002, "Snakeskin", 2));
        }

        public static GameItem CreateGameItem(int itemID)
        {
            // Using LINQ to go through the list and find the first item that is valid
            GameItem standardItem = standardItems.FirstOrDefault(item => item.ItemID == itemID);

            if (standardItem != null)
            {
                // Clone the object
                return standardItem.Clone();
            }

            return null;
        }
    }
}

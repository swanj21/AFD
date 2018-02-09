using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public Weapon(int itemID, string name, int price, int minDamage, int maxDamage) 
            : base(itemID, name, price)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public new Weapon Clone()
        {
            return new Weapon(ItemID, Name, Price, MinDamage, MaxDamage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGame1._2
{
    class AllWeapons : List<Weapon>
    {
        public AllWeapons()
        {
            Add(new Weapon(0, "Rusty Knife", 1, 1, 3));
            Add(new Weapon(1, "Wooden staff", 1, 1, 3));
            Add(new Weapon(2, "Dagger", 2, 1, 5));
            Add(new Weapon(3, "Whip", 2, 1, 5));
            Add(new Weapon(4, "Iron Axe", 3, 2, 6));
            Add(new Weapon(5, "Silver Sword", 3, 2, 6));
            Add(new Weapon(6, "Spear", 2, 1, 5));
            Add(new Weapon(7, "Halberd", 2, 1, 5));
            Add(new Weapon(8, "Atgeir", 3, 3, 6));
            Add(new Weapon(9, "Spiked Mace", 3, 2, 6));
            Add(new Weapon(10, "Iron Glove", 2, 1, 5));
            Add(new Weapon(11, "Druidic Staff", 2, 1, 5));
            Add(new Weapon(12, "Saarian Blade", 4, 3, 7));
            Add(new Weapon(13, "Ancient Axe", 2, 1, 5));
            Add(new Weapon(14, "Weaponized Pickaxe", 2, 1, 5));
            Add(new Weapon(15, "Skeleton Arm", 1, 1, 3));


            //Add(new Order(Guid.NewGuid(), 2, false,
            //                          new DateTime(2017, 9, 5), 5, 19));
        }
    }
}


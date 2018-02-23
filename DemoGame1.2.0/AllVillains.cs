using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGame1._2
{
    class AllVillains : List<Villain>
    {
        public AllVillains()
        {
            Add(new Villain(1, "Drunkard", 3, 1, 1));
            Add(new Villain(2, "Maniac", 4, 1, 2));
            Add(new Villain(3, "Retired Thief", 5, 2, 3));
            Add(new Villain(4, "Cursed Kid", 6, 2, 4));
            Add(new Villain(5, "Irritated Pirate", 7, 3, 5));
            Add(new Villain(6, "Flexing Barbarian", 8, 3, 6));
            Add(new Villain(7, "Twisted Druid", 9, 4, 7));
            Add(new Villain(8, "Injured Berserker", 10, 4, 8));
            Add(new Villain(9, "Psychotic Priest", 11, 4, 9));
            Add(new Villain(10, "The Jarl", 15, 5, 10));


            //Add(new Order(Guid.NewGuid(), 2, false,
            //                          new DateTime(2017, 9, 5), 5, 19));
        }
    }
}

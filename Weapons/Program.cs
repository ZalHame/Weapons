using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    class Program
    {
        static void Main()
        {
            Blacksmith blacksmith = new Blacksmith();
            Sword sword = new Sword();
            Grenade grenade = new Grenade();
            Knife knife = new Knife();
            sword.MeleeHit();
            Console.WriteLine(sword);
            grenade.RangeHit();
            Console.WriteLine(grenade);
            knife.MeleeHit();
            knife.RangeHit();
            Console.WriteLine(knife);
        }
    }
}
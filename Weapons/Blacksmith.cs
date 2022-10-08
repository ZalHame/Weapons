using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class Blacksmith
    {
        public void Repair(IRepairWeapon weapon)
        {
            weapon.Durability += 20;
            Console.WriteLine($"{weapon.Name} repaired");
        }
        public void Upgrade(IUpgradeWeapon weapon)
        {
            weapon.Level += 1;
            Console.WriteLine($"{weapon.Name} was upgraded");
        }
    }
}

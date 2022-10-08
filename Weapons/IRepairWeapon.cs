using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal interface IRepairWeapon : IWeapon
    {
        public int Durability { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal interface IWeapon
    {
        public int Damage { get; set; }
        public string Name { get; }
    }
}

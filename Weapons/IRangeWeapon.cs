using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal interface IRangeWeapon : IWeapon
    {
        public int Amount { get; set; }
        void RangeHit();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class Grenade : IRangeWeapon, IUpgradeWeapon
    {
        public string Name => "Grenade";
        public int Damage { get; set; }
        public int Amount { get; set; }
        public int _level_ { get; set; }
        public int Level
        {
            get
            {
                return this._level_;
            }
            set
            {
                this._level_ = value;
                this.Damage = this._level_ * 100;
            }
        }
        public Grenade()
        {
            Damage = 0;
            Amount = 5;
            Level = 1;
        }

        public void RangeHit()
        {
            if (this.Amount > 0)
            {
                this.Damage = this.Level * 100;
                this.Amount -= 1;
                Console.WriteLine("Bam");
            }
            else
            {
                this.Amount = 0;
                this.Damage = 0;
                Console.WriteLine($"This weapon broke, durability: {this.Amount}");
            }
            
        }
        public override string ToString()
        {
            return ($"Weapon - {Name}\n" +
                    $"Damage - {Damage}\n" +
                    $"Durability - {Amount}\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class Sword : IMeleeWeapon, IRepairWeapon ,IUpgradeWeapon
    {
        public string Name => "Katana";
        public int Damage { get; set; }
        public int Durability { get; set; }
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
                this.Damage = this._level_ * 10;
            } 
        }

        public Sword()
        {
            Damage = 0;
            Durability = 100;
            Level = 1;
        }

        public void MeleeHit()
        {
            if (this.Durability > 0)
            {
                this.Damage = this.Level * 10;
                this.Durability -= 5;
                Console.WriteLine("Chak");
            }
            else
            {
                this.Durability = 0;
                this.Damage = 0;
                Console.WriteLine($"This weapon broke, durability: {this.Durability}");
            }
        }
        public override string ToString()
        {
            return ($"Weapon - {Name}\n" +
                    $"Damage - {Damage}\n" +
                    $"Durability - {Durability}\n");
        }
    }
}

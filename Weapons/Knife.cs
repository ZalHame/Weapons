using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class Knife : IMeleeWeapon, IRangeWeapon, IUpgradeWeapon, IRepairWeapon
    {
        public string Name => "Kunai";
        public int Damage { get; set; }
        public int Durability { get; set; }
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
                this.Damage = this._level_ * 5;
            }
        }
        public Knife()

        {
            Damage = 0;
            Durability = 50;
            Amount = 5;
            Level = 1;
        }
        public void MeleeHit()
        {
            if (this.Durability > 0)
            {
                this.Damage = this.Level * 5;
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
        public void RangeHit()
        {
            if (this.Amount > 0)
            {
                this.Damage = this.Level * 5;
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
                    $"Durability - {Durability}\n" +
                    $"Amount - {Amount}\n");
        }
    }
}
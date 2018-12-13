using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    public class Player : Character
    {
        public int Level { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Sneak { get; set; }
        public int Luck { get; set; }
        public Inventory Inventory { get; set; }
        
        public int Damage { get; set; }

        public void DealDamage(Character character)
        {
            character.Health -= Damage + Attack;
        }

        public void TakeDamage(int amount)
        {
            this.Health -= amount - Defense;
        }
    }
}

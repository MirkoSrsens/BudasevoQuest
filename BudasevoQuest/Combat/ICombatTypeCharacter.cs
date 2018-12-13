using GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat
{
    public interface ICombatTypeCharacter
    {
        int Damage { get; set; }

        void DealDamage(Character character);

        void TakeDamage(int amount);
    }
}

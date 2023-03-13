using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skyrim_Battle
{
    public class Nord : ICharacter
    {
        public int Heath {get; private set;} = 110;

        public Attack Attack()
        {
            Random rng = newRandom();
            if (rng.Next(0,3) == 0)
            {
                return new Attack("Sword Slash", 10, AttackType.Slashing);
            }
            else if(rng.Next(0,3) == 1)
            {
                return new Attack("Bow Shot", 10, AttackType.Ranged);
            }
            else
            {
                return new Attack("Fire Bolt", 10, AttackType.Magic);
            }
        }

        public string TakeDamage(Attack attack)
        {
            if (attack.Type == AttackType.Magic)
            {
                Health -= (attack.Damage + 3);
            }
            else if(attack.Type == AttackType.Slashing)
            {
                Health -= (attack.Damage - 3);
            }
            else
            {
                Health -= (attack.Damage);
            }
            return "Ahhh, I'll Kill You";
        }
    }
}
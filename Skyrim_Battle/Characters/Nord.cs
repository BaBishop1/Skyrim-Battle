using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skyrim_Battle
{
    public class Nord : ICharacter
    {
        public int Health {get; private set;} = 100;

        public Attack Attack()
        {
            Random rng = new Random();
            int atk = rng.Next(0,3);
            if (atk == 0)
            {
                Attack attack1 = new Attack("Sword Slash", 10, AttackType.Slashing);
                return attack1;
            }
            else if(atk == 1)
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
            return "Ahhh, I'll Kill You!";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skyrim_Battle
{
    public interface ICharacter
    {
        int Health{get;}
        Attack Attack();
        public string TakeDamage(Attack attack);
    }

    public enum AttackType{Slashing, Magic, Ranged}

    public class Attack
    {
        public string Name{get;}
        public int Damage{get;}
        public AttackType Type{get;}

        public Attack(string name, int damage, AttackType type)
        {
            Name = name;
            Damage = damage;
            Type = type;
        }
    }

    
}
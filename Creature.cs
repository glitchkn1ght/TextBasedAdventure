using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
   public interface ICreature
    {
         string CreatureName { get; set; }
         int CreatureBaseAccuracy { get; set; }
         int CreatureBaseStrength { get; set; }
         int MaxHp { get; set; }
         int CurrentHp { get; }
         IWeapon CreatureDefaultWeapon { get; set; }
         IArmour CreatureDefaultArmour { get; set; }
         IAttackBehaviour Attack { get; set; }
         void SetHp(int damage);
    }

   public abstract class Creature : ICreature
   {
       public string CreatureName { get; set; }
       public int CreatureBaseAccuracy { get; set; }
       public int CreatureBaseStrength { get; set; }
       public int MaxHp { get; set; }
       public int CurrentHp { get; private set; }

       public IWeapon CreatureDefaultWeapon { get; set; }
       public IArmour CreatureDefaultArmour { get; set; }
       public IAttackBehaviour Attack { get; set; }

       public void SetHp(int damage)
       {
           CurrentHp = CurrentHp - damage;
       }



   }

   public class Monster : Creature
   {
       protected Monster(string name, int acc, int str, IWeapon wep, IArmour arm)
       {
           CreatureName = name;
           CreatureBaseAccuracy = acc;
           CreatureBaseStrength = str;
           CreatureDefaultWeapon = wep;
           CreatureDefaultArmour = arm;
       }
    }

   public class allMonster
   {
       public List<Monster> AvailableArmors()
       {
           List<Monster> availableArmors = new List<Monster>
           {
               new Monster("CacoDemon",50, 5,null,null)

           };
           return availableArmors;
       }
   }




    public class GameMethods
    {
        public int RandomNum(int min, int max)
        {
            Random Rand = new Random();
            int n = Rand.Next(min, max);
            return n;
        }
    }

}

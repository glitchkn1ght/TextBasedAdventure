using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
   public interface ICreature
    {
         string CreatureName { get; set; }
         int CreatureBaseAccuracy { get; set; }
         int CreatureBaseStrength { get; set; }
         IWeapon CreatureDefaultWeapon { get; set; }
         IArmour CreatureDefaultArmour { get; set; }
         IAttackBehaviour Attack { get; set; }
         int PerformAttackSequence();
         
    } 
   
    public interface IAttackBehaviour
    {
        bool HitYN(int acc);
        int CalcDamage();

    }




    public class standardAttack : IAttackBehaviour
    {
       public int Lowerlimit { get; set; }
       public int Upperlimit { get; set; }

       public standardAttack(ICreature creature)
       {
           Lowerlimit = creature.CreatureDefaultWeapon.MinDamage;
           Upperlimit = Convert.ToInt32(Math.Floor(creature.CreatureDefaultWeapon.MaxDamage * 0.7));
       }

       public void SetLimits(int lower, int upper)
       {
           Lowerlimit = lower;
           Upperlimit = upper;
       }

       public bool HitYN(int acc)
       {
            GameMethods GM = new GameMethods();
            int HitRand = GM.RandomNum(1, 100);

            if (HitRand >= 100)
            {
                return true;
            }
            else
            {
                return false;
            }

       }

       public int CalcDamage()
        { 
       GameMethods GM = new GameMethods();
            int dam = GM.RandomNum(Lowerlimit, Upperlimit);
            return dam ;
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

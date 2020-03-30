using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    public interface IAttackBehaviour
    {
        bool HitYN();
        int CalcDamage();
    }

    public class standardAttack : IAttackBehaviour
    {
        public int Lowerlimit { get; set; }
        public int Upperlimit { get; set; }


        public  ICreature ClientCreature { get; set; }


        public standardAttack(ICreature creature)
        {
            Lowerlimit = creature.CreatureDefaultWeapon.MinDamage;
            Upperlimit = Convert.ToInt32(Math.Floor(creature.CreatureDefaultWeapon.MaxDamage * 0.7));
            ClientCreature = creature;
        }

        public void SetLimits(int lower, int upper)
        {
            Lowerlimit = lower;
            Upperlimit = upper;
        }

        public bool HitYN()
        {
            GameMethods GM = new GameMethods();
            int HitRand = GM.RandomNum(Lowerlimit, Upperlimit);

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
            return dam;
        }

        public int AttackResult()
        {
            int Result = 0;
            Console.WriteLine(ClientCreature.CreatureName "attacks..");
            if (HitYN() == true)
            {
                Console.WriteLine("and hits!");
                Result = CalcDamage();
                Console.WriteLine(ClientCreature.CreatureName "does {0} damage", Result);
                return Result;
            }
            else
            {
                Console.WriteLine("and misses....");
                return Result;
            }
            
            
            
            
        }


    }

}

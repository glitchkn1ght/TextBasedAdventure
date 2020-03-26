using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    class Creature
    {
        public IAttackBehaviour Attack;
        public string CreatureName { get; set; }

    }


    public interface IAttackBehaviour
    {
        int PerformAttack(int str);
    }


    public class standardAttack : IAttackBehaviour
    {
       public int Lowerlimit { get; set; }
       public int Upperlimit { get; set; }

       public standardAttack()
       {
           Lowerlimit = 1;
           Upperlimit = 3;
       }

       public void SetLimits(int lower, int upper)
       {
           Lowerlimit = lower;
           Upperlimit = upper;
       }

       public int PerformAttack(int str)
        {

            GameMethods GM = new GameMethods();
            GM.RandomNum(Lowerlimit, Upperlimit);
            return str ;
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

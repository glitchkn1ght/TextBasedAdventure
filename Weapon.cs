using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
   public interface IWeapon
    {
          string WeaponName { get; set; }
         int MinDamage { get; set; }
         int MaxDamage { get; set; }
    }
}

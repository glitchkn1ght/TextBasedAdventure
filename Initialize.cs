using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponLibrary;
using ArmorLibrary;

namespace TextBasedAdventure
{
    class Initialize
    {
        public List<Weapon> WeaponList { get; set; }
        public List<Armor> ArmorList { get; set; }


        public  Initialize()
        {
            allWeapons W = new allWeapons();
            allArmors A = new allArmors();
            WeaponList = W.AvailableWeapons();
            ArmorList = A.AvailableArmors();

        }


   

    }
}

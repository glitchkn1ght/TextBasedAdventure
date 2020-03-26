using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventure
{
    public interface IArmour
    {
         string ArmourName { get; set; }
         int DamageReduction { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDependencyInjectionCore
{
    internal class Sword : IWeapon
    {
        public string SwordName { get; set; }   
        public Sword(string swordName)
        {
            SwordName = swordName;
        }

        public Sword()
        {
            SwordName = "Moonlight Greatsword";
        }

        public void AttackWithMe()
        {
            System.Console.WriteLine(SwordName + " slices through the air, devastating all enemies");
        }
    }
}

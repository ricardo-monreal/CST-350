using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDependencyInjectionCore
{
    internal class Grenade : IWeapon
    {
        public Grenade(string weaponName)
        {
            WeaponName = weaponName;
        }

        public Grenade()
        {
            WeaponName = "Pathetic granede. No name provided";
        }

        public string WeaponName { get; set; }

        public void AttackWithMe()
        {
            Console.WriteLine(WeaponName + " sizzles for a moment and then expldoes into a shower of deadly metal fragments");
        }
    }
}

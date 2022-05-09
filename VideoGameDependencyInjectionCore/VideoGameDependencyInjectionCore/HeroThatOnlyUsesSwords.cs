using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDependencyInjectionCore
{
    
    internal class HeroThatOnlyUsesSwords : IHero
    {
        public string Name { get; set; }

        public HeroThatOnlyUsesSwords(string name)
        {
            Name = name;
        }

        public HeroThatOnlyUsesSwords()
        {
            Name = "Ranni";
        }

        public void Attack()
        {
            Sword sword = new Sword("Excalibur");
            Console.WriteLine(Name + " prepares himself for the battle.");
            sword.AttackWithMe();
        }
    }
}

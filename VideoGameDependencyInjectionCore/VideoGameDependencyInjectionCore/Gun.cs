using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDependencyInjectionCore
{
    internal class Gun : IWeapon
    {
        public string Name { get; set; }
        public List<Bullet> Bullets { get; set; }

        public Gun(string name, List<Bullet> bullets)
        {
            this.Name = name;
            this.Bullets = bullets;
        }

        public void AttackWithMe()
        {
            if (Bullets.Count > 0)
            {
                Console.WriteLine(Name + " fires the round called " + Bullets[0 ].Name + ". The victem now has deadly hole in him");
                Bullets.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("The gun has no bullets. Nothing happens");
            }
        }
    }
}
